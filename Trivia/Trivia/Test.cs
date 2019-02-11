using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{

    class Test : TestQuestions
    {
        public Test()
        {
            Welcome();
        }

        public void Welcome()
        {
            Console.WriteLine("Hello and welcome to Stevens Trivia Game!");
            Console.WriteLine("This quiz will test you on three different subjects, History, Geography, and Music!");
            TakeTest();
        }


        private void TakeTest()
        {
            string testAnswer;
            int score = 0;
            Random rand = new Random();
            Questions questions = new Questions();

            Console.Write("Which subject would you like to be tested in? History, Geography, or Music: ");
            string answer = Console.ReadLine();

            // checks answer to set the questions through abstract class TestQuestions
            if (answer == "history")
            {
                testquestions = questions.history;
            }
            else if (answer == "geography")
            {
                testquestions = questions.geo;
            }
            else if (answer == "music")
            {
                testquestions = questions.music;
            }

            // displays word bank
            for (int i = 0; i < testquestions.Length; i++)
            {
                Console.WriteLine(testquestions[0, i]);
            }

            questions.Shuffle(rand, testquestions);

            Console.WriteLine("\n Score: " + score + "/5");


            for (int i = 0; i < testquestions.Length; i++)
            {
                // ask the player the answer
                Console.Write(testquestions[i, 1] + ": ");
                testAnswer = Console.ReadLine().ToLower();

                // checks players answer with correct answer
                if (testAnswer == testquestions[i, 0])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Correct! " + testAnswer + " was the correct answer!");
                    score++;
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, " + testAnswer + "was incorrect. The answer was " + testquestions[i, 0]);
                    Console.ResetColor();
                }
            }

            End(score);
        }

        public void End(int a)
        {
            Console.WriteLine("Your final score was " + a + " out of five");
            Console.Write("Would you like to try another quiz? Y or N:");
            ConsoleKeyInfo endAnswer = Console.ReadKey();
            if (endAnswer.Key == ConsoleKey.Y)
            {
                TakeTest();
            }
            else if (endAnswer.Key == ConsoleKey.N)
            {
                Console.Clear();
                Console.WriteLine("Thank you for playing! Press enter to quit.");
                Console.ReadKey();
            }
        }
    }
}
