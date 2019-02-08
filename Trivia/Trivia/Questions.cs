using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trivia
{
    public abstract class NewQuestions
    {
        public string newQuestion;
        public string newAnswer;
    }

    class Questions : NewQuestions
    {
        Questions()
        {

        }

        public void Question()
        {
            string[] questions = {"In what year did the walls of Constaninople fall to Ottoman Empire?" +
                              "What year was the Constitution of The United States written?" +
                              "Which Soviet satellite was the first to be launched into space in 1957?" +
                              "What is the earliest surviving system of laws?" +
                              "The Treaty of Versailles followed which war?" +
                              "What is Earth's largest continent?" +
                              "In what country can you visit Machu Picchu?" +
                              "What is the largest country on the Arabian Peninsula?" +
                              "What is the tallest mountain in the world?" +
                              "What is the fastest flowing river in the world?" +
                              "Which country is NOT part of the Scaninavian Peninsula?" +
                              "What pop singer is known as The Material Girl?" +
                              "What band did Prince form in 1981?" +
                              "What was the band known as Linkin Park originally called?" +
                              "What singer holds the world record for most words in a hit single?" +
                              "What singer is known as the Empress of the Blues?"}; // question from http://www.usefultrivia.com/history_trivia/index_iv.html

            string[] answers = {"1453", "1787", "Sputnik", "Code of Hammurabi", "World War 1", "Asia", "Peru", "Saudia Arabia", "Mount Everest", "Amazon" +
                            "Denmark", "Madonna", "The Time", "Xeno" , "Eminem", "Bessie Smith"}; // answers from http://www.usefultrivia.com/history_trivia/index_iv.html
        }
        



        //ArraySegment<String> questionsHist = new ArraySegment<String>(questions, 0, 4);
        //@"C:/Users/srami/Documents/Homework/OOP/TriviaGame/TriviaGame/Trivia/Trivia/Questions.txt"
    }
}
