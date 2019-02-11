using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trivia
{
    public abstract class TestQuestions
    {
        public string[,] testquestions;
    }

    class Questions : TestQuestions
    {
        public Questions()
        {

        }

        public string[,] history = new string[5, 2]
        {
            {"In what year did the walls of Constaninople fall to Ottoman Empire?", "1453" },
            {"What year was the Constitution of The United States written?", "1787"},
            {"Which Soviet satellite was the first to be launched into space in 1957?", "Sputnik"},
            {"What is the earliest surviving system of laws?", "Code of Hammurabi"},
            {"The Treaty of Versailles followed which war?", "World War 1"}
        };

        public string[,] geo = new string[5, 2]
        {
            {"What is Earth's largest continent?", "Asia"},
            {"In what country can you visit Machu Picchu?", "Peru"},
            {"What is the largest country on the Arabian Peninsula?", "Saudia Arabia"},
            {"What is the tallest mountain in the world?", "Mount Everest"},
            {"Which country is NOT part of the Scaninavian Peninsula?", "Denmark"}
        };

        public string[,] music = new string[5, 2]
        {
            {"What pop singer is known as The Material Girl?", "Madonna"},
            {"What band did Prince form in 1981?", "The Time"},
            {"What was the band known as Linkin Park originally called?", "Xeno"},
            {"What singer holds the world record for most words in a hit single?", "Eminem"},
            {"What singer is known as the Empress of the Blues?", "Bessie Smith"}
        };


        public void Shuffle<T>(Random rand, T[,] testquestions)
        {

            int n = testquestions.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + rand.Next(n - i);

                T t = testquestions[r, 0];
                T d = testquestions[r, 1];

                testquestions[r, 0] = testquestions[i, 0];
                testquestions[r, 1] = testquestions[i, 1];

                testquestions[i, 0] = t;
                testquestions[i, 1] = d;
            }
        }
    }
}    
