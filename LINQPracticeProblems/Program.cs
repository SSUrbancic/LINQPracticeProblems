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
            ////Return list that contains substrings
            //List<string> wordList = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var newWordList = wordList.Where(word => word.Contains("th"));
            //foreach (var word in newWordList)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadLine();

            ////Return a copy of a list without any duplicates
            //List<string> nameList = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike", "Mike", "Nick" };
            //var newNameListNoDuplicates = nameList.GroupBy(name => name).Select(name => name.First());
            //foreach (var name in newNameListNoDuplicates)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();


            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            var listOfAverages = classGrades.Select(grades => grades.Split(',')).Select(grades => Array.ConvertAll(grades, double.Parse)).Select(grades => (grades.Sum() - grades.Min()) / (grades.Count() - 1)).Average();

            Console.WriteLine(listOfAverages);

            Console.ReadLine();
        }
    }
}
