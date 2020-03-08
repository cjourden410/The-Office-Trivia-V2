Use TheOfficeDB
Delete from MCAnswer
Delete from Question
Delete from Trivia_Question
Delete from Trivia

Insert Trivia (name)
Values ('Dunder Mifflin'),
('Regional Managers'),
('Sales'),
('The Annex'),
('Corporate');

Insert Question (question_id, text)
Values (1, 'What color t-shirt did the Scranton branch wear at the company picnic?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Green', 1, 0),
('Orange', 1, 0),
('Dark Blue', 1, 0),
('Red', 1, 1),
('Dark Purple', 1, 0);

Insert Question (question_id, text)
Values (2, 'All you can eat of pretty good pizza is better than a medium amount of good pizza?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('True', 2, 0),
('False', 2, 1);

Insert Question (question_id, text)
Values (3, 'Of the below, what was not included on the Fun Run t-shirt?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Fun Run Race', 3, 0),
('Michael Scarn', 3, 1),
('Celebrity Rabies Awareness', 3, 0),
('Pro-Am', 3, 0),
('Scranton', 3, 0);

Insert Question (question_id, text)
Values (4, 'What was the original air date of the first episode?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('March 24, 2005', 4, 1),
('April 8, 2005', 4, 0),
('March 19, 2004', 4, 0),
('April 1, 2004', 4, 0),
('March 22, 2005', 4, 0);

Insert Question (question_id, text)
Values (5, 'In the episode “Trivia”, which of the following was not a team that participated in trivia night');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Dunder Mifflin A-Team', 5, 0),
('Tequila Mockingbird', 5, 1),
('Queerenstein Bears', 5, 0),
('Two Broke Dorks', 5, 0),
('The Einsteins', 5, 0);

Insert Question (question_id, text)
Values (6, 'In the episode “Costume Contest” who ended up winning the Scranton-area coupon book with a total of $15,000 in savings?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Gabe', 6, 0),
('Oscar', 6, 1),
('Creed', 6, 0),
('Kelly', 6, 0),
('Kevin', 6, 0);

Insert Question (question_id, text)
Values (7, 'Which of the following was not included in Pam’s portfolio during her art gallery presentation?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('The Scranton Business Park', 7, 0),
('A Vase of Flowers', 7, 0),
('A Stapler', 7, 0),
('A Mug Filled with Pens', 7, 1),
('A Bowl of Fruit', 7, 0);

Insert Question (question_id, text)
Values (8, 'In the “Goodbye Toby” Episode, when Phyllis calls information about an anti-gravity machine, who is the voice on the phone?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Mindy Kaling (Kelly)', 8, 0),
('Angela Kinsey (Angela)', 8, 0),
('Jenna Fischer (Pam)', 8, 0),
('Kate Flannery (Meredith)', 8, 0),
('Amy Ryan (Holly)', 8, 1);

Insert Question (question_id, text)
Values (9, 'Which of the following did not tell the press about Sabre printers catching fire?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Andy', 9, 0),
('Pam', 9, 0),
('Daryl', 9, 0),
('Kelly', 9, 0),
('Ryan', 9, 1);

Insert Question (question_id, text)
Values (10, 'How much is Ryan wanting to charge per month for WUPHF?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('$9.99', 10, 0),
('$10.99', 10, 0),
('$11.99', 10, 0),
('$12.99', 10, 1),
('$13.99', 10, 0);

Insert Question (question_id, text)
Values (11, 'What is the name of the IT Guy brought in by Saber?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Shadow', 11, 0),
('Garth', 11, 0),
('Nick', 11, 1),
('Sam', 11, 0),
('Robby', 11, 0);

Insert Question (question_id, text)
Values (12, 'What is the name of the actress that the office debated was hot or not?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Hilary Swank', 12, 1),
('Katie Holmes', 12, 0),
('Sandra Bullock', 12, 0),
('Jennifer Garner', 12, 0),
('Angelina Jolie', 12, 0);

Insert Question (question_id, text)
Values (13, 'What branch do Michael and Holly accidentally let everyone know is closing at the company picnic?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Buffalo', 13, 1),
('Utica', 13, 0),
('Albany', 13, 0),
('Nashua', 13, 0),
('Rochester', 13, 0);

Insert Question (question_id, text)
Values (14, 'Which of the following will you not find on Michael’s desk?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Blue Train Car', 14, 0),
('Newton’s Cradle', 14, 0),
('Pink Fez Hat', 14, 0),
('Dunder Mifflin Toy Semi Truck', 14, 0),
('Zen Garden', 14, 1);

Insert Question (question_id, text)
Values (15, 'How many months was Andy gone on his sailing trip?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('2', 15, 0),
('1', 15, 0),
('4', 15, 0),
('3', 15, 1),
('5', 15, 0);

Insert Question (question_id, text)
Values (16, 'When Michael assumes that Donna is cheating on him, what is he eating when Jim and Pam run into him in the breakroom?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Mayonnaise and Black Olives', 16, 1),
('Yogurt', 16, 0),
('Sour Cream and Onions', 16, 0),
('Ice Cream', 16, 0),
('Ice Cream Cake', 16, 0);

Insert Question (question_id, text)
Values (17, 'Which Halloween costume has Jim Halpert not worn?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Three Hole Punch Jim', 17, 0),
('Popeye', 17, 0),
('Chris Bosh', 17, 0),
('“David”', 17, 1),
('Facebook', 17, 0);

Insert Question (question_id, text)
Values (18, 'What was the name Jim used for his “The Ultimate Guide to Throwing a Garden Party” book?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Jim Prankerington', 18, 0),
('Jim Trickerington', 18, 0),
('Jim Prankington', 18, 0),
('Jimothy Prankston', 18, 0),
('Jim Trickington', 18, 1);

Insert Question (question_id, text)
Values (19, 'What does Todd Packer’s vanity license plate say?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('IM Hung', 19, 0),
('4GoodTime', 19, 0),
('Packman', 19, 0),
('WL Hung', 19, 1);

Insert Question (question_id, text)
Values (20, 'Which celebrity did Dwight claim was injured in a car accident?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Brad Pitt', 20, 1),
('Tom Hanks', 20, 0),
('Will Ferrell', 20, 0),
('George Clooney', 20, 0),
('Matt Damon', 20, 0);

Insert Question (question_id, text)
Values (21, 'What song does Dwight play Michael for his birthday on his recorder?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('The Longest Time', 21, 1),
('Happy Birthday', 21, 0),
('Just The Way You Are', 21, 0),
('My Life', 21, 0),
('Shout', 21, 0);

Insert Question (question_id, text)
Values (22, 'When staying at The Schrute Farms Bed and Breakfast, what did Jim say were the changes that he and Pam would be murdered?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('3 in 10', 22, 0),
('1 in 3', 22, 0),
('1 in 5', 22, 0),
('1 in 6', 22, 1),
('1 in 8', 22, 0);

Insert Question (question_id, text)
Values (23, 'When discussing names for Schrute Farms Bed and Breakfast, which of the following was not mentioned by Jim and Pam?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('The Beets Motel', 23, 0),
('The Four Beets Resort', 23, 1),
('The Embassy Beets', 23, 0),
('Radish Inn', 23, 0),
('Borscht Hotel', 23, 0);

Insert Question (question_id, text)
Values (24, 'What was the cause of Toby’s injury that put him in the hospital during his trip to Costa Rica?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Fell getting off the plane', 24, 0),
('Zipline Incident', 24, 1),
('Hiking Incident', 24, 0),
('Scuba Diving Malfunction', 24, 0),
('Bungie Jumping Incident', 24, 0);

Insert Question (question_id, text)
Values (25, 'Which of the following never sat in the Annex?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Jim', 25, 0),
('Ryan', 25, 0),
('Dwight', 25, 0),
('Holly', 25, 0),
('Pam', 25, 1);

Insert Question (question_id, text)
Values (26, 'What is the name of Toby’s daughter?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Sofia', 26, 0),
('Sasha', 26, 1),
('Isabelle', 26, 0),
('Annie', 26, 0),
('Lisa', 26, 0);

Insert Question (question_id, text)
Values (27, 'Which character was once a seminarian?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Dwight', 27, 0),
('Oscar', 27, 0),
('Phyllis', 27, 0),
('Creed', 27, 0),
('Toby', 27, 1);

Insert Question (question_id, text)
Values (28, 'What state did Angela also say she had two men fighting over her?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Michigan', 28, 0),
('Utah', 28, 0),
('Ohio', 28, 1),
('Texas', 28, 0),
('New York', 28, 0);

Insert Question (question_id, text)
Values (29, 'What is the name of Kevin’s band?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Net Present Value', 29, 1),
('Be Audit You Can Be', 29, 0),
('Kevin and the Zits', 29, 0),
('Scrantonicity', 29, 0),
('LIFO', 29, 0);

Insert Question (question_id, text)
Values (30, 'Kevin’s band mostly covers music from which band?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('The Who', 30, 0),
('The Police', 30, 1),
('Phil Collins', 30, 0),
('U2', 30, 0),
('Duran Duran', 30, 0);

Insert Question (question_id, text)
Values (31, 'What is Kevin’s favorite movie?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Zoolander', 31, 0),
('Varsity Blues', 31, 0),
('American Pie 2', 31, 1),
('Joe Dirt', 31, 0),
('Rush Hour 2', 31, 0);

Insert Question (question_id, text)
Values (32, 'After David Wallace buys Dunder Mifflin, what name does Robert California introduce himself with?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Bob Kazamakis', 32, 1),
('Robert California', 32, 0),
('Robert Cranston', 32, 0),
('Bob Acula', 32, 0),
('Rob Kirilenko', 32, 0);

Insert Question (question_id, text)
Values (33, 'The first time Jo Bennet’s comes to the Scranton Branch, what is the breed of the two dogs with her?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('One Sheltie and One Great Dane', 33, 0),
('Two Great Danes', 33, 2),
('Two Shelties', 33, 0),
('One Yellow Lab and One Sheltie', 33, 0),
('One Yellow Lab and One Great Dane', 33, 0);

Insert Question (question_id, text)
Values (34, 'Which of the following was not on the Corporate Volleyball team during the company retreat?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('David Wallace', 34, 0),
('Charles Minor', 34, 0),
('Paul Kendall', 34, 0),
('Thomas Dean', 34, 1);

Insert Question (question_id, text)
Values (35, 'What was the name of Jan’s assistant Hunter’s band?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('The Wanted', 35, 0),
('The Hunted', 35, 1),
('Lights Out Houston', 35, 0),
('The Unforgiven', 35, 0),
('Tue Days from Twosday', 35, 0);

Insert Question (question_id, text)
Values (36, 'What is the name of the receptionist at the Dunder Mifflin corporate office?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('Ronni', 36, 0),
('Rolando', 36, 0),
('Polly', 36, 0),
('Emily', 36, 0),
('Grace ', 36, 1);

Insert Question (question_id, text)
Values (37, 'What is the Dunder Mifflin New York Stock Exchange Symbol?');
Insert MCAnswer (choice, question_id, is_correct)
Values ('DMI', 37, 1),
('DMF', 37, 0),
('DUN', 37, 0),
('DMP', 37, 0);

Insert Trivia_Question (trivia_id, question_id)
Values ((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 1)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 2)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 3)),
((select trivia_id from trivia where name = 'Regional Managers'), (select question_id from Question where question_id = 3)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 4)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 5)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 6)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 7)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 8)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 9)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 10)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 11)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 12)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 13)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 14)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 15)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 16)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 17)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 18)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 19)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 20)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 21)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 22)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 23)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 24)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 25)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 26)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 27)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 28)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 29)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 30)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 31)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 32)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 33)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 34)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 35)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 36)),
((select trivia_id from trivia where name = 'Dunder Mifflin'), (select question_id from Question where question_id = 37)),
((select trivia_id from trivia where name = 'Regional Managers'), (select question_id from Question where question_id = 14)),
((select trivia_id from trivia where name = 'Regional Managers'), (select question_id from Question where question_id = 15)),
((select trivia_id from trivia where name = 'Regional Managers'), (select question_id from Question where question_id = 16)),
((select trivia_id from trivia where name = 'Sales'), (select question_id from Question where question_id = 17)),
((select trivia_id from trivia where name = 'Sales'), (select question_id from Question where question_id = 18)),
((select trivia_id from trivia where name = 'Sales'), (select question_id from Question where question_id = 19)),
((select trivia_id from trivia where name = 'Sales'), (select question_id from Question where question_id = 20)),
((select trivia_id from trivia where name = 'Sales'), (select question_id from Question where question_id = 21)),
((select trivia_id from trivia where name = 'Sales'), (select question_id from Question where question_id = 22)),
((select trivia_id from trivia where name = 'Sales'), (select question_id from Question where question_id = 23)),
((select trivia_id from trivia where name = 'The Annex'), (select question_id from Question where question_id = 24)),
((select trivia_id from trivia where name = 'The Annex'), (select question_id from Question where question_id = 25)),
((select trivia_id from trivia where name = 'The Annex'), (select question_id from Question where question_id = 26)),
((select trivia_id from trivia where name = 'The Annex'), (select question_id from Question where question_id = 27)),
((select trivia_id from trivia where name = 'The Annex'), (select question_id from Question where question_id = 28)),
((select trivia_id from trivia where name = 'The Annex'), (select question_id from Question where question_id = 29)),
((select trivia_id from trivia where name = 'The Annex'), (select question_id from Question where question_id = 30)),
((select trivia_id from trivia where name = 'The Annex'), (select question_id from Question where question_id = 31)),
((select trivia_id from trivia where name = 'Corporate'), (select question_id from Question where question_id = 32)),
((select trivia_id from trivia where name = 'Corporate'), (select question_id from Question where question_id = 33)),
((select trivia_id from trivia where name = 'Corporate'), (select question_id from Question where question_id = 34)),
((select trivia_id from trivia where name = 'Corporate'), (select question_id from Question where question_id = 35)),
((select trivia_id from trivia where name = 'Corporate'), (select question_id from Question where question_id = 36)),
((select trivia_id from trivia where name = 'Corporate'), (select question_id from Question where question_id = 37));