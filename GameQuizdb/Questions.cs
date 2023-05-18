using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz
{
     public class Questions
    {
        public Program Program { get; set; }
        public Questions(Program dbh)
        {
            Program = dbh;
        }

        public List<DataBaseQuestions> MixList()
        {
            Random rnd = new Random();
            var mixedQuestions = Program.Db.Questions
                .Where(q => q.Category == "Mars")
                .ToList()
                .OrderBy(q => rnd.Next())
                .ToList();
            //ListOfQuestions.OrderBy(q => rnd.Next()).ToList();
            return mixedQuestions;
        }

        public static bool GetBooleanInput()
        {
            while (true)
            {
                try
                {
                    bool input = bool.Parse(Console.ReadLine().ToLower());
                    return input;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Only true or false are accepted");
                }
            }

        }

        public void MakingAQuestionnaire()
        {
            List<DataBaseQuestions> mixedQueastions = MixList();
            int rightAnswers = 0;
            for (int tries = 2; tries != 0; tries--)
            {
                var question = mixedQueastions.First();
                Console.WriteLine(question.Text);
                bool input = GetBooleanInput();
                bool correctAnswer = question.Answer;
                mixedQueastions.RemoveAt(0);

                if (correctAnswer == input)
                {
                    rightAnswers++;
                    Console.WriteLine($"Great! You got this one right! Alien was kind and gave you water. Yay!\n");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Program.CallSuccessOne();
                    return;
                }
                Console.WriteLine($"Oh no! You got this one wrong.\n");
            }
            Console.WriteLine($"Watch out! The alien is attacking! What to do!?!");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            Program.CallFailOne();
            return;
        }

        public void MakingAQuestionnaire2()
        {

            List<DataBaseQuestions> mixedQueastions = MixList();
            int rightAnswers = 0;
            for (int tries = 2; tries != 0; tries--)
            {
                var question = mixedQueastions.First();
                Console.WriteLine(question.Text);
                bool input = GetBooleanInput();
                bool correctAnswer = question.Answer;
                mixedQueastions.RemoveAt(0);

                if (correctAnswer == input)
                {
                    rightAnswers++;
                    Console.WriteLine($"Great! You got this one right! Alien was kind and gave you water. Yay!\n");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Program.CallSuccessTwo();
                    return;
                }
                Console.WriteLine($"Oh no! You got this one wrong.\n");
            }
            Console.WriteLine($"Watch out! The alien is attacking! What to do!?!");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            Program.CallFailTwo();
            return;
        }
    }
}
