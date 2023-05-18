using Microsoft.EntityFrameworkCore;

namespace GameQuiz
{
    public class Program
    {
        public QuizContext Db { get; set; }

        public string Planet { get; set; }

        public Questions Questions { get; set; }

        static void Main(string[] args)
        {

            Program p = new();
            var optionsBuilder = new DbContextOptionsBuilder<QuizContext>();
            optionsBuilder.UseSqlServer(_connStr);
            p.Db = new QuizContext(optionsBuilder.Options);
            p.Questions = new Questions(p);
            p.Run();

        }
        private void Run()
        {
            //Program databaseH = new();
            //databaseH.CreateDataBase();

            //Marien koodi
            //kutsutaan database ja luonnin jälkeen kommenttiin takas
            //Program p = new Program();
            //p.CreateDataBase();

            Console.WriteLine("             .--.           .---.        .-.\r\n         .---|--|   .-.     | S |  .---. |~|    .--.\r\n      .--|===|HI|---|_|--.__| C |--|:::| |~|-==-|==|---.\r\n      |%%|   |ST|===| |~~|%%| I |--|   |_|~|LOTR|  |___|-.\r\n      |  |   |OR|===| |==|  | F |  |:::|=| |    |  |---|=|\r\n      |  |   |Y |   |_|__|  | I |__|   | | |    |  |___| |\r\n      |~~|===|--|===|~|~~|%%|~~~|--|:::|=|~|----|==|---|=|\r\n      ^--^---'--^---^-^--^--^---'--^---^-^-^-==-^--^---^-'");
            Console.WriteLine("\n               Welcome to The Book Escape Game");

            Console.WriteLine("\nPick a book \n1 History \n2 Sci-Fi \n3 The Lord Of The Rings");
            int pickedBook = 0;
            int.TryParse(Console.ReadLine(), out pickedBook);
            switch (pickedBook)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine("           /\\                                                                                     /\\\r\n _         )( ______________________                                       ______________________ )(         _\r\n(_)///////(**)______________________> You haven't unlocked this level yet <______________________(**)\\\\\\\\\\\\\\(_)\r\n           )(                                                                                     )(\r\n           \\/                                                                                     \\/");
                    Console.WriteLine("                                               Please start again.");
                    return;

                case 2:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("                     `. ___\r\n                    __,' __`.                _..----....____\r\n        __...--.'``;.   ,.   ;``--..__     .'    ,-._    _.-'\r\n  _..-''-------'   `'   `'   `'     O ``-''._   (,;') _,'\r\n,'________________                          \\`-._`-','\r\n `._              ```````````------...___   '-.._'-:\r\n    ```--.._      ,.                     ````--...__\\-.\r\n            `.--. `-`                       ____    |  |`\r\n              `. `.                       ,'`````.  ;  ;`\r\n                `._`.        __________   `.      \\'__/`\r\n                   `-:._____/______/___/____`.     \\  `\r\n                               |       `._    `.    \\\r\n                               `._________`-.   `.   `.___\r\n                                                  `------'`");
                    Console.WriteLine("\n\nYou picked a Sci-Fi adventure book. Let's go!");
                    ChooseAPlanet();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("                                             _______________________\r\n   _______________________-------------------                       `\\\r\n /:--__                                                              |\r\n||< > |                                   ___________________________/\r\n| \\__/_________________-------------------                         |\r\n|                                                                  |\r\n |                       THE LORD OF THE RINGS                      |\r\n |                                                                  |\r\n |      \"Three Rings for the Elven-kings under the sky,             |\r\n  |        Seven for the Dwarf-lords in their halls of stone,        |\r\n  |      Nine for Mortal Men doomed to die,                          |\r\n  |        One for the Dark Lord on his dark throne                  |\r\n  |      In the Land of Mordor where the Shadows lie.                 |\r\n   |       One Ring to rule them all, One Ring to find them,          |\r\n   |       One Ring to bring them all and in the darkness bind them   |\r\n   |     In the Land of Mordor where the Shadows lie.                |\r\n  |                                              ____________________|_\r\n  |  ___________________-------------------------                      `\\\r\n  |/`--_                                                                 |\r\n  ||[ ]||                                            ___________________/\r\n   \\===/___________________--------------------------");
                    Console.WriteLine("\n\nYou haven't unlocked this level yet. Please start again.");
                    return;

                default:
                    Console.WriteLine("\nYou need to pick a book 1, 2 or 3:");
                    break;
            }

            Console.WriteLine("\nPress enter to Continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("     .                           ,             .                .\r\n               # ## #      .                              .        .\r\n             #  #O## ###                .                        .\r\n   .        #*# *# ##*###                       .                     ,\r\n        .   ##*# *# ## ##               .                     .\r\n      .      ##*#* #o##*#         .                             ,       .\r\n          .    #*#  # #     .                    .             .          ,\r\n                                .                         .\r\n____^/\\___^--____/\\____O______________/\\/\\---/\\___________---______________\r\n   /\\^   ^  ^    ^                  ^^ ^  '\\ ^          ^       ---\r\n         --           -            --  -      -         ---  __       ^\r\n   --  __                      ___--  ^  ^                         --  __");
            CallChapterOne();
            Console.WriteLine("\nPress enter to Continue");
            Console.ReadLine();
            Console.Clear();

            CallChapterTwo();
            Questions.MakingAQuestionnaire();
            Console.WriteLine("\nPress enter to Continue");
            Console.ReadLine();
            Console.Clear();

            CallChapterThree();
            Console.WriteLine("\nPress enter to Continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine();

            Questions.MakingAQuestionnaire2();
            Console.WriteLine("\nPress enter to Continue");
            Console.ReadLine();
            Console.Clear();
            TheEndAtMars();
        }
        
        //Marien koodi
        private const string _connStr = "server=(localdb)\\MSSQLLocalDb;database=BookEscapeGame";
        //private const string _connStr = "Server=tcp:ahtiacademy.database.windows.net,1433;Initial Catalog = marie; Persist Security Info=False;User ID = sqladmin; Password=Salainen1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;\r\n";
        public void CreateDataBase()
        {
            Console.WriteLine("Aloitellaan");

            //Marien koodi
            Console.WriteLine("Aloitellaan");
            var optionsBuilder = new DbContextOptionsBuilder<QuizContext>();
            optionsBuilder.UseSqlServer(_connStr);
            Db = new QuizContext(optionsBuilder.Options);
            /////////////////////////////////////////////////////////

            while (true)
            {
                Console.WriteLine("\n0: Exit");
                Console.WriteLine("1: Delete database");
                Console.WriteLine("2: Create new database");
                Console.WriteLine("3: Add story");
                Console.WriteLine("4: Add questions");
                Console.WriteLine("5: Print output");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        Db.Database.EnsureDeleted();
                        Console.WriteLine("Database deleted");
                        break;
                    case 2:
                        Db.Database.EnsureCreated();
                        Console.WriteLine($"Database {_connStr} created");
                        break;
                    case 3:
                        AddStory();
                        Console.WriteLine($"Story {_connStr} added");
                        break;
                    case 4:
                        AddQuestionMars();
                        AddQuestionSaturn();
                        AddQuestionPluto();
                        Console.WriteLine($"Questions {_connStr} added");
                        break;
                    case 5:
                        PrintOut();
                        break;
                    default:
                        Console.WriteLine("Choose one");
                        break;
                }
            }

        }

        public void PrintOut()
        {

            var d = Db.Stories.Include(k => k.Chapters);

            foreach (Story tarina in d)
            {
                Console.WriteLine($"\nID:{tarina.Id} ");
                Console.WriteLine($"Gategory:{tarina.Category}");
                Console.WriteLine($"start: {tarina.StartText}");
                Console.WriteLine($"end: {tarina.EndText}");
                foreach (var chapter in tarina.Chapters)
                {
                    Console.WriteLine(@$" Chapter:{chapter.Chapter}");
                    Console.WriteLine(@$" Success:{chapter.Success}");
                    Console.WriteLine(@$" Fail:{chapter.Fail}");
                }

            }

        }
        public void AddStory()
        {

            string category = "Scifi";

            Story s = new Story { Category = category };
            //Console.WriteLine("Enter a context: Pluto, Mars, Saturn, MiddleEarth, TheShire , Dachau\n");

            string context = "Mars";
            s.Context = context;

            string startText = "Mars is the fourth planet from the Sun – a dusty, cold, desert world with a very thin atmosphere.\n" +
                                  "Mars is also a dynamic planet with seasons, polar ice caps, canyons, \n" +
                                  "extinct volcanoes, and evidence that it was even more active in the past.\n" +
                                  "\nYou just landed.\nYou are almost out of water and your mission is to find it from the planet.\n";
            s.StartText = startText;


            string endText = "\n\n       __..._   _...__\r\n  _..-\"      `Y`      \"-._\r\n  \\   THE     |           /\r\n  \\\\          |    END   //\r\n  \\\\\\         |         ///\r\n   \\\\\\ _..---.|.---.._ ///\r\n    \\\\`_..---.Y.---.._`//\r\n     '`               `'\n" +
                                "\n\nYour journey at the BookEscape Game has come to an end. Pick another book if you dare.\n";

            s.EndText = endText;

            //Story s = new Story { Category = category, Context = context, StartText = startText, EndText = endText };
            Db.Stories.Add(s);

            s.Chapters = new List<Chapters>();

            string chapter1 = "\nA dusty cold and icy landscape opens before your eyes.\n" +
                                  "You are freezing in the cold and have to take a sweater from your backbag.\n" +
                                  "Everything looks deserted and the landscape is red all over.\n" +
                                  "You can almost feel the warm sun rays but the overwhelming cold swipes them away.\n" +
                                  "The water in your bottle will slowly start to freeze and you can already see it becoming slushy.\n" +
                                  "you will have to find a refill soon. You head north towards the volcanoes far away in the horizon\n";

            Chapters mc1 = new Chapters { Chapter = chapter1 };

            string success1 = "\nNow you have enough water to continue on your way towards the volcanoes.\n" +
                                      "The air feels thin and breathing is heavy. Your stomach starts rumbling and you need to find some food.\n" +
                                      "Where could you find something to eat?\n" +
                                      "You remember the protein bar that your dear grandma gave you before you entered the space ship.\n" +
                                      "You stop by at a marsian stonehenge to eat it.\n";
            mc1.Success = success1;

            string fail1 = "\nYOU'RE BEING ATTACKED! You look around to find somoe aid. Some 10 meters away you see an abandoned house.\n" +
                                   " You run inside the house and look around to find any weapon.\n" +
                                   "The door slams close behind your back and startled you turn around.\n" +
                                   "At the same time you realize there is a gun leaning toward the wall.\n\n\n" +
                                   "\n                                      )  (  (    (\r\n                                         (  )  () @@  )  (( (\r\n                                     (      (  )( @@  (  )) ) (\r\n                                   (    (  ( ()( /---\\   (()( (\r\n     _______                            )  ) )(@ !O O! )@@  ( ) ) )\r\n    <   ____)                      ) (  ( )( ()@ \\ o / (@@@@@ ( ()( )\r\n /--|  |(  o|                     (  )  ) ((@@(@@ !o! @@@@(@@@@@)() (\r\n|   >   \\___|                      ) ( @)@@)@ /---\\-/---\\ )@@@@@()( )\r\n|  /---------+                    (@@@@)@@@( // /-----\\ \\\\ @@@)@@@@@(  .\r\n| |    \\ =========______/|@@@@@@@@@@@@@(@@@ // @ /---\\ @ \\\\ @(@@@(@@@ .  .\r\n|  \\   \\\\=========------\\|@@@@@@@@@@@@@@@@@ O @@@ /-\\ @@@ O @@(@@)@@ @   .\r\n|   \\   \\----+--\\-)))           @@@@@@@@@@ !! @@@@ % @@@@ !! @@)@@@ .. .\r\n|   |\\______|_)))/             .    @@@@@@ !! @@ /---\\ @@ !! @@(@@@ @ . .\r\n \\__==========           *        .    @@ /MM  /\\O   O/\\  MM\\ @@@@@@@. .\r\n    |   |-\\   \\          (       .      @ !!!  !! \\-/ !!  !!! @@@@@ .\r\n    |   |  \\   \\          )   -cfbd-   .  @@@@ !!     !!  .(. @.  .. .\r\n    |   |   \\   \\        (    /   .(  . \\)). ( |O  )( O! @@@@ . )      .\r\n    |   |   /   /         ) (      )).  ((  .) !! ((( !! @@ (. ((. .   .\r\n    |   |  /   /   ()  ))   ))   .( ( ( ) ). ( !!  )( !! ) ((   ))  ..\r\n    |   |_<   /   ( ) ( (  ) )   (( )  )).) ((/ |  (  | \\(  )) ((. ).\r\n____<_____\\\\__\\__(___)_))_((_(____))__(_(___.oooO_____Oooo.(_(_)_)((_" +
                                   "\n\nAfter shooting the alien you continue your way towards the volcanoes.\n";

            mc1.Fail = fail1;

            s.Chapters.Add(mc1);

            string chapter2 = "\n   .-.\r\n |(@ @)\r\n \\ \\-/\r\n  \\/ \\\r\n   \\ /\\\r\n   _H_ \\ \n" +
                                     "\n\nSuddenly an alien comes to your way. \n\nIs it friendly? \nHope so... It asks you a question.\n" +
                                     "Better get the answer right.. Maybe it gives us water then.\n";
            Chapters mc2 = new Chapters { Chapter = chapter2 };

            string success2 = "\nYou unfroze the lake and got enough water to survive the hike back to your space ship and go back home.\n" +
                                         "\n       !\r\n       !\r\n       ^\r\n      / \\\r\n     /___\\\r\n    |=   =|\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n    |     |\r\n   /|##!##|\\\r\n  / |##!##| \\\r\n /  |##!##|  \\\r\n|  / ^ | ^ \\  |\r\n| /  ( | )  \\ |\r\n|/   ( | )   \\|\r\n    ((   ))\r\n   ((  :  ))\r\n   ((  :  ))\r\n    ((   ))\r\n     (( ))\r\n      ( )\r\n       .\r\n       .\r\n       ." +
                                         "\n\nYou have escaped the book, congrats!\n";
            mc2.Success = success2;

            string fail2 = "\nHow could you let this happen??!!! Your grandma will be devastated with sorrow.\n" +
                              "The alien chops you into small pieces that drift away into the timeless space untill\n" +
                              "they end up in a neverending black hole.\n" +
                              "\n              .-\"\"\"\"-.\r\n             /        \\\r\n            /_        _\\\r\n           // \\      / \\\\\r\n           |\\__\\    /__/|\r\n            \\    ||    /\r\n             \\        /\r\n              \\  __  /  \\  /          ________________________________\r\n               '.__.'    \\/          /                                 \\\r\n                |  |     /\\         |    This is my second Encounter   |\r\n                |  |    O  O        |          of the Alien Kind !     |\r\n                ----    //         O \\_________________________________/\r\n               (    )  //        O\r\n              (\\\\     //       o\r\n             (  \\\\    )      o\r\n             (   \\\\   )   /\\\r\n   ___[\\______/^^^^^^^\\__/) o-)__\r\n  |\\__[=======______//________)__\\\r\n  \\|_______________//____________|\r\n      |||      || //||     |||\r\n      |||      || @.||     |||\r\n       ||      \\/  .\\/      ||\r\n                  . .\r\n                 '.'.`\n" +
                              "\n\n... and it didn't go too well...\n";
            mc2.Fail = fail2;

            s.Chapters.Add(mc2);

            string chapter3 = "\n   _____ _ __ __ ____ _  _____\r\n =-=-_-__=_-= _=_=-=_,-'\"'\"\"--,_\r\n  =- _=-=- -_=-=_,-\"           \r\n    =- =- -=.--\\n" +
                                         "\n\nYou see a frozen lake on the horizon.Maybe you can get water for your journey back..\n\nAnother alien is coming.\n" +
                                         "Hopefully this one goes smoothly..\n\nIt asks a question. Better answer right or we wont get home...\n";
            Chapters mc3 = new Chapters { Chapter = chapter3 };

            string success3 = "";
            mc3.Success = success3;

            string fail3 = "";
            mc3.Fail = fail3;

            s.Chapters.Add(mc3);

            Db.SaveChanges();
        }

        public void AddQuestionMars() // Mars
        {
            DataBaseQuestions a = new DataBaseQuestions
            {
                Category = "Mars",
                Text = "The red colour of Mars comes from the high level of iron: true or false?",
                Answer = true,
            };
            Db.Questions.Add(a);
            DataBaseQuestions b = new DataBaseQuestions
            {
                Category = "Mars",
                Text = "Mars is bigger than Earth: true or false?",
                Answer = false,
            };
            Db.Questions.Add(b);
            DataBaseQuestions c = new DataBaseQuestions
            {
                Category = "Mars",
                Text = "The average temperature in Mars is around -65 celsius: true or false?",
                Answer = true,
            };
            Db.Questions.Add(c);
            DataBaseQuestions d = new DataBaseQuestions
            {
                Category = "Mars",
                Text = "Galileo Galilei discovered Mars through a telescope: true or false?",
                Answer = true,
            };
            Db.Questions.Add(d);
            DataBaseQuestions e = new DataBaseQuestions
            {
                Category = "Mars",
                Text = "Mars is a rocky planet: true or false?",
                Answer = true,
            };
            Db.Questions.Add(e);
            DataBaseQuestions f = new DataBaseQuestions
            {
                Category = "Mars",
                Text = "Mars is called the Red Planet: true or false?",
                Answer = true,
            };
            Db.Questions.Add(f);
            DataBaseQuestions g = new DataBaseQuestions
            {
                Category = "Mars",
                Text = "Mars has 3 moons: true or false?",
                Answer = false,
            };
            Db.Questions.Add(g);
            DataBaseQuestions h = new DataBaseQuestions
            {
                Category = "Mars",
                Text = "Mars is the closest planet to the sun: true or false?",
                Answer = false,
            };
            Db.Questions.Add(h);
            DataBaseQuestions k = new DataBaseQuestions
            {
                Category = "Mars",
                Text = "Mars is 3 billion years old: true or false?",
                Answer = false,
            };
            Db.Questions.Add(k);
            DataBaseQuestions l = new DataBaseQuestions
            {
                Category = "Mars",
                Text = "You can see Mars from Earth without a telescope: true or false?",
                Answer = true,
            };
            Db.Questions.Add(l);
            Db.SaveChanges();
        }
        public void AddQuestionSaturn() //saturn
        {
            DataBaseQuestions a = new DataBaseQuestions
            {
                Category = "Saturn",
                Text = "Saturn has it’s own light: true or false? ",
                Answer = false,
            };
            Db.Questions.Add(a);
            DataBaseQuestions b = new DataBaseQuestions
            {
                Category = "Saturn",
                Text = "What differentiates planets from stars is that stars have their own light: true or false?",
                Answer = true,
            };
            Db.Questions.Add(b);
            DataBaseQuestions c = new DataBaseQuestions
            {
                Category = "Saturn",
                Text = "Saturn is the largest planet in the solar system: true or false? ",
                Answer = false,
            };
            Db.Questions.Add(c);
            DataBaseQuestions d = new DataBaseQuestions
            {
                Category = "Saturn",
                Text = "Earth has a stronger magnetic field than Saturn: true or false?",
                Answer = true,
            };
            Db.Questions.Add(d);
            DataBaseQuestions e = new DataBaseQuestions
            {
                Category = "Saturn",
                Text = "Saturn has a ring system composed of mainly ice particles: true or false?",
                Answer = true,
            };
            Db.Questions.Add(e);
            DataBaseQuestions f = new DataBaseQuestions
            {
                Category = "Saturn",
                Text = "There is no water in Saturn: true or false?",
                Answer = false,
            };
            Db.Questions.Add(f);
            DataBaseQuestions g = new DataBaseQuestions
            {
                Category = "Saturn",
                Text = "Saturn has 8 main rings: true or false?",
                Answer = false,
            };
            Db.Questions.Add(g);
            DataBaseQuestions h = new DataBaseQuestions
            {
                Category = "Saturn",
                Text = "One of Saturn’s moons is called Titan: true or false?",
                Answer = true,
            };
            Db.Questions.Add(h);
            DataBaseQuestions k = new DataBaseQuestions
            {
                Category = "Saturn",
                Text = "Saturn has 97 moons: true or false?",
                Answer = false,
            };
            Db.Questions.Add(k);
            DataBaseQuestions l = new DataBaseQuestions
            {
                Category = "Saturn",
                Text = "The Romans named the seventh day of the week Saturday (\"Saturn's Day\"), for the planet Saturn: true or false?",
                Answer = true,
            };
            Db.Questions.Add(l);
            Db.SaveChanges();
        }

        public void AddQuestionPluto() // Pluto
        {
            DataBaseQuestions a = new DataBaseQuestions
            {
                Category = "Pluto",
                Text = "Pluto was discovered in 1930: true of false?",
                Answer = true,
            };
            Db.Questions.Add(a);
            DataBaseQuestions b = new DataBaseQuestions
            {
                Category = "Pluto",
                Text = "The temperature of Pluto can be -230 C: true or false?",
                Answer = true,
            };
            Db.Questions.Add(b);
            DataBaseQuestions c = new DataBaseQuestions
            {
                Category = "Pluto",
                Text = "Pluto's rotation time around the sun takes 248 years 197 days 5.5 hours: true or false?",
                Answer = true,
            };
            Db.Questions.Add(c);
            DataBaseQuestions d = new DataBaseQuestions
            {
                Category = "Pluto",
                Text = "Pluto has 6 moons: true or false?",
                Answer = false,
            };
            Db.Questions.Add(d);
            DataBaseQuestions e = new DataBaseQuestions
            {
                Category = "Pluto",
                Text = "Pluto is a planet: true or false?",
                Answer = false,
            };
            Db.Questions.Add(e);
            DataBaseQuestions f = new DataBaseQuestions
            {
                Category = "Pluto",
                Text = "Pluto orbits in the Kuiper belt: true or false?",
                Answer = true,
            };
            Db.Questions.Add(f);
            DataBaseQuestions g = new DataBaseQuestions
            {
                Category = "Pluto",
                Text = "Pluto has moons named Charon and Kerberos: true or false?",
                Answer = true,
            };
            Db.Questions.Add(g);
            DataBaseQuestions h = new DataBaseQuestions
            {
                Category = "Pluto",
                Text = "Pluto is named after the Roman god Manala: true or false?",
                Answer = true,
            };
            Db.Questions.Add(h);
            DataBaseQuestions k = new DataBaseQuestions
            {
                Category = "Pluto",
                Text = "Is Pluto a plutoid?",
                Answer = true,
            };
            Db.Questions.Add(k);
            DataBaseQuestions l = new DataBaseQuestions
            {
                Category = "Pluto",
                Text = "Pluto is partly composed of ice: true or false?",
                Answer = true,
            };
            Db.Questions.Add(l);
            Db.SaveChanges();
        }

        public void AtMars()
        {
            var marsStartText = Db.Stories
            ;
            foreach (var mars in marsStartText)
            {
                Console.WriteLine(mars.StartText);
                Console.WriteLine("                       :\r\n                       :\r\n        .              :\r\n         '.            :           .'\r\n           '.          :         .'\r\n             '.   .-\"\"\"\"\"\"-.   .'                                   .'':\r\n               '.\"          \".'                               .-\"\"\"\"-.'         .---.          .----.        .-\"\"\"-.\r\n                :            :                _    _        .\"     .' \".    ...\"     \"...    .\"      \".    .\"       \".\r\n        .........            .........    o  (_)  (_)  ()   :    .'    :   '..:.......:..'   :        :    :         :    \r\n                :            :                              :  .'      :       '.....'       '.      .'    '.       .'\r\n                 :          :                             .'.'.      .'                        `''''`        `'''''`\r\n                  '........'                              ''   ``````\r\n                 .'    :   '.\r\n               .'      :     '.\r\n             .'        :       '.\r\n           .'          :         '.\r\n                       :");
            }
        }
        public void TheEndAtMars()
        {
            var marsEndText = Db.Stories
            ;
            foreach (var mars in marsEndText)
            {
                Console.WriteLine(mars.EndText);
            }
        }

        public void CallChapterOne()
        {
            var d = Db.Stories.Include(k => k.Chapters);

            foreach (Story tarina in d)
            {
                Console.WriteLine($"\n");
                foreach (var chapter in tarina.Chapters.Where(c => c.Id == 1))
                {
                    Console.WriteLine(@$"{chapter.Chapter}");
                }

            }
        }

        public void CallChapterTwo()
        {
            var d = Db.Stories.Include(k => k.Chapters);

            foreach (Story tarina in d)
            {
                Console.WriteLine($"\n");
                foreach (var chapter in tarina.Chapters.Where(c => c.Id == 2))
                {
                    Console.WriteLine(@$"{chapter.Chapter}");
                }

            }
        }

        public void CallChapterThree()
        {
            var d = Db.Stories.Include(k => k.Chapters);

            foreach (Story tarina in d)
            {
                Console.WriteLine($"\n");
                foreach (var chapter in tarina.Chapters.Where(c => c.Id == 3))
                {
                    Console.WriteLine(@$"{chapter.Chapter}");
                }

            }
        }

        public void CallFailOne()
        {
            var d = Db.Stories.Include(k => k.Chapters);

            foreach (Story tarina in d)
            {
                Console.WriteLine($"\n");
                foreach (var F in tarina.Chapters.Where(c => c.Id == 1))
                {
                    Console.WriteLine(@$"{F.Fail}");
                }

            }
        }

        public void CallFailTwo()
        {
            var d = Db.Stories.Include(k => k.Chapters);

            foreach (Story tarina in d)
            {
                Console.WriteLine($"\n");
                foreach (var F in tarina.Chapters.Where(c => c.Id == 2))
                {
                    Console.WriteLine(@$"{F.Fail}");
                }

            }
        }

        public void CallSuccessOne()
        {
            var d = Db.Stories.Include(k => k.Chapters);

            foreach (Story tarina in d)
            {
                Console.WriteLine($"\n");
                foreach (var S in tarina.Chapters.Where(c => c.Id == 1))
                {
                    Console.WriteLine(@$"{S.Success}");
                }

            }
        }

        public void CallSuccessTwo()
        {
            var d = Db.Stories.Include(k => k.Chapters);

            foreach (Story tarina in d)
            {
                Console.WriteLine($"\n");
                foreach (var S in tarina.Chapters.Where(c => c.Id == 2))
                {
                    Console.WriteLine(@$"{S.Success}");
                }

            }
        }

        public void ChooseAPlanet()
        {
            while (true)
            {
                Console.WriteLine("\n\nTo which planet would you like to travel first \n1 Mars \n2 Pluto \n3 Saturn");
                int pickedPlanet = 0;
                int.TryParse(Console.ReadLine(), out pickedPlanet);

                switch (pickedPlanet)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\nYour destination is Mars.\n");
                        AtMars();
                        return;

                    case 2:
                        Console.Clear();
                        //Console.WriteLine("Your destination is Pluto.\n");
                        Console.WriteLine("\nYou haven't unlocked this level yet.");
                        //return;
                        break;

                    case 3:
                        Console.Clear();
                        //Console.WriteLine("Your destination is Saturn.\n");
                        Console.WriteLine("\nYou haven't unlocked this level yet.");
                        //return;
                        break;

                    default:
                        Console.WriteLine("\nYou need to pick a planet 1, 2 or 3:");
                        break;
                }
            }
        }
    }
}

