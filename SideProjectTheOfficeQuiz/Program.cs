using Microsoft.Extensions.Configuration;
using SideProjectTheOfficeQuiz.ConsoleModels;
using SideProjectTheOfficeQuiz.DAL;
using SideProjectTheOfficeQuiz.Models;
using SideProjectTheOfficeQuiz.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SideProjectTheOfficeQuiz
{
    class Program
    {
        static ITriviaSqlDAO triviaDAO;
        static double? score = null;
        static Dictionary<string, double?> triviaDictionary = new Dictionary<string, double?>();

        static void Main(string[] args)
        {
            // Get the connection string from the appsettings.json file
            IConfigurationBuilder builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("TheOfficeDB");
            
            triviaDAO = new TriviaSqlDAO(connectionString);

            SelectAQuiz();

            Console.WriteLine();
            Console.WriteLine("Thanks for playing - Please come back to Scranton, PA soon!");
            Console.ReadLine();
        }

        static void SelectAQuiz()
        {
            // Loop until the user is done
            bool quit = false;

            while (!quit)
            {
                Console.Clear();

                // Print heading

                // Show the user the list of quizzes
                //Print each quiz
                Dictionary<int, string> choices = new Dictionary<int, string>();
                int choice = 1;
                Console.WriteLine(@"
  _____ _             ___   __  __ _            _____     _       _       
 |_   _| |__   ___   / _ \ / _|/ _(_) ___ ___  |_   _| __(_)_   _(_) __ _ 
   | | | '_ \ / _ \ | | | | |_| |_| |/ __/ _ \   | || '__| \ \ / / |/ _` |
   | | | | | |  __/ | |_| |  _|  _| | (_|  __/   | || |  | |\ V /| | (_| |
   |_| |_| |_|\___|  \___/|_| |_| |_|\___\___|   |_||_|  |_| \_/ |_|\__,_|");
                Console.WriteLine();
                //Console.WriteLine($"{"Options",10}{"Score",44}");
                //Console.WriteLine("=========================================================");
                Console.WriteLine($"{"Options",19}{"Score",43}"); // Have 3 equals signs on each side
                Console.WriteLine($"{"========================================================",64}"); // This indentation is good
                IList<string> trivias = triviaDAO.GetAllTriviaTypes();
                string scoreString = "";
                foreach (string t in trivias) // developed foreach loop to populate our dictionary of trivia to be able to track scores on main menu
                {
                    if(triviaDictionary.ContainsKey(t))
                    {
                        break;
                    }
                    else
                    {
                        triviaDictionary[t] = null;
                    }
                }
                #region Working code but not updating score
                //foreach (string triviaName in trivias)
                //{
                //    //double? score = null;
                //    //Tuple<string, double?> t = new Tuple<string, double?>(triviaName, score);
                //    //choices.Add(choice, t);
                //    choices.Add(choice, triviaName); // Working version
                //    scoreString = "---";
                //    //double? score = null;
                //    if (score.HasValue)
                //    {
                //        scoreString = $"{Math.Round(score.Value)}%";
                //    }
                //    Console.WriteLine($"{choice,13}) {triviaName,-40} {scoreString,5}");
                //    choice++;
                //}
                #endregion
                #region Updated code to track scores properly
                foreach (KeyValuePair<string, double?> kvp in triviaDictionary)
                {
                    string triviaName = kvp.Key;
                    choices.Add(choice, triviaName); // Working version
                    scoreString = "---";
                    double? score = kvp.Value;
                    if (score.HasValue)
                    {
                        scoreString = $"{Math.Round(score.Value)}%";
                    }
                    Console.WriteLine($"{choice,13}) {triviaName,-40} {scoreString,5}");
                    choice++;
                }
                #endregion
                // Allow user to select one to take
                bool validSelection = false;
                int selection = 0;
                while (!validSelection)
                {
                    Console.WriteLine();
                    Console.Write("Select a subject (Q to quit): ");
                    string input = Console.ReadLine().ToLower();

                    if (input.StartsWith("q"))
                    {
                        quit = true;
                        return;
                    }
                    if (!int.TryParse(input, out selection))
                    {
                        // try again
                        continue;
                    }
                    if (!choices.ContainsKey(selection))
                    {
                        continue;
                    }
                    validSelection = true;

                }
                // Ok, take the quiz
                Trivia triviaToTake = triviaDAO.GetTrivia(choices[selection]); // This works
                TriviaTaker triviaTaker = new TriviaTaker(triviaToTake);
                triviaTaker.TakeTrivia(true);
                // Record the score
                string triviaTaken = triviaToTake.Name;
                triviaDictionary[triviaTaken] = triviaToTake.Score; // NEED TO FIGURE OUT
                //score = triviaToTake.Score; // makes all lines the same score

                Console.ReadLine();
            }
        }
    }
}
