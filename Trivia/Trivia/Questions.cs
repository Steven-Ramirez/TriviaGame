using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trivia
{

    class Questions
    {
        Questions()
        {
            Welcome();
        }

        public void Welcome()
        {
            Console.WriteLine("Hello and welcome to Stevens Trivia Game!");
            Console.WriteLine("This quiz will test you on three different subjects, History, Geography, and Music!");
            Console.Write("Which subject would you like to be tested in? (H)istory, (G)eography, or (M)usic: ");
            string answer = Console.ReadLine();
        }

        public void Question()
        {

            List<string> history = new List<string>();
            string[] fileHistoryQuestions = File.ReadAllLines("History.txt"); // question from http://www.usefultrivia.com/history_trivia/index_iv.html
            history.AddRange(fileHistoryQuestions);

            List<string> historyAnswers = new List<string>();
            string[] fileHistoryAnswers = File.ReadAllLines("HistoryAnswers.txt"); // question from http://www.usefultrivia.com/history_trivia/index_iv.html
            historyAnswers.AddRange(fileHistoryAnswers);

            List<string> geo = new List<string>();
            string[] fileGeoQuestions = File.ReadAllLines("Geo.txt"); // answers from http://www.usefultrivia.com/history_trivia/index_iv.html*/
            geo.AddRange(fileGeoQuestions);

            List<string> geoAnswers = new List<string>();
            string[] fileGeoAnswers = File.ReadAllLines("GeoAnswers.txt"); // question from http://www.usefultrivia.com/history_trivia/index_iv.html
            geoAnswers.AddRange(fileGeoAnswers);

            List<string> music = new List<string>();
            string[] fileMusicQuestions = File.ReadAllLines("Music.txt"); // answers from http://www.usefultrivia.com/history_trivia/index_iv.html*/
            music.AddRange(fileMusicQuestions);

            List<string> musicAnswers = new List<string>();
            string[] fileMusicAnswers = File.ReadAllLines("MusicAnswers.txt"); // question from http://www.usefultrivia.com/history_trivia/index_iv.html
            musicAnswers.AddRange(fileMusicAnswers);



        }

       
        



        //@"C:/Users/srami/Documents/Homework/OOP/TriviaGame/TriviaGame/Trivia/Trivia/Questions.txt"
    }
}
