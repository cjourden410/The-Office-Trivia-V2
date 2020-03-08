using SideProjectTheOfficeQuiz.ConsoleModels;
using SideProjectTheOfficeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectTheOfficeQuiz
{
    public class TriviaOptions
    {
        public static TriviaC DunderMifflin
        {
            get
            {
                return new TriviaC()
                {
                    Name = "Dunder Mifflin",
                    Questions = new List<QuestionC>()
                    {
                        new FillInQuestionsC("In what city is Dunder Mifflin located?", "Scranton", false, true),
                        new MultipleChoiceQuestionsC("What color t-shirt did the Scranton branch wear at the company picnic?", "D",
                        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Green" },
                            {"B", "Orange" },
                            {"C", "Dark Blue" },
                            {"D", "Red" },
                            {"E", "Dark Purple" },
                        }),
                        new TrueFalseQuestionsC("All you can eat of pretty good pizza is better than a medium amount of good pizza?", "false")
                    }
                };
            }
        }
        public static TriviaC RegionalManagers
        {
            get
            {
                return new TriviaC()
                {
                    Name = "Regional Managers",
                    Questions = new List<QuestionC>()
                {
                    new MultipleChoiceQuestionsC("Of the below, what was not included on the Fun Run t-shirt?", "B",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                        {"A", "Fun Run Race" },
                        {"B", "Michael Scarn" },
                        {"C", "Celebrity Rabies Awareness" },
                        {"D", "Pro-Am" },
                        {"E", "Scranton" },
                    }),
                }
                };
            }
        }

        public static TriviaC Sales
        {
            get
            {
                return new TriviaC()
                {
                    Name = "Sales",
                    Questions = new List<QuestionC>()
                {
                    new MultipleChoiceQuestionsC("Placeholder question, need to add something here?", "A",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                        {"A", "TBD" },
                        {"B", "TBD" },
                        {"C", "TBD" },
                        {"D", "TBD" },
                        {"E", "TBD" },
                    }),
                }
                };
            }
        }

        public static TriviaC TheAnnex
        {
            get
            {
                return new TriviaC()
                {
                    Name = "The Annex",
                    Questions = new List<QuestionC>()
                {
                    new MultipleChoiceQuestionsC("Placeholder question, need to add something here?", "A",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                        {"A", "TBD" },
                        {"B", "TBD" },
                        {"C", "TBD" },
                        {"D", "TBD" },
                        {"E", "TBD" },
                    }),
                }
                };
            }
        }

        public static TriviaC Corporate
        {
            get
            {
                return new TriviaC()
                {
                    Name = "Corporate",
                    Questions = new List<QuestionC>()
                {
                    new MultipleChoiceQuestionsC("Placeholder question, need to add something here?", "A",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                        {"A", "TBD" },
                        {"B", "TBD" },
                        {"C", "TBD" },
                        {"D", "TBD" },
                        {"E", "TBD" },
                    }),
                }
                };
            }
        }
        // nothing below this line
    }
}
