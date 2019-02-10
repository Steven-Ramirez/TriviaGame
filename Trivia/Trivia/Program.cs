using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trivia
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = File.ReadAllLines("Questions.txt");
            ArraySegment<String> questionsHist = new ArraySegment<String>(questions, 0, 5);
            //ArraySegment<String> questionsGeo = new ArraySegment<String>(questions, 5, 10);
            //ArraySegment<String> questionsMusic = new ArraySegment<String>(questions, 10, 14);
            Console.WriteLine(questionsHist);
            Console.ReadLine();
        }
    }
}
