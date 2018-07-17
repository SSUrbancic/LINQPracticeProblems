using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var newWordList = wordList.Where(word => word.Contains("th"));
            foreach(var word in newWordList)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }

    }
}
