using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathmatics" };
            //var results = words.Where(w => w.Contains("th"));
            //foreach(var result in results)
            //{
            //    Console.WriteLine(result);
            //}          
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Mike", "Charles", "Nevin", "David", "Mike", "Tony", "Brett"};
            //var distinctNames = names.Distinct();
            //foreach (var name in distinctNames)
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
            string[] grades;
            
            foreach (var stringOfGrades in classGrades)
            {
                grades = stringOfGrades.Split(',');
                var numbers = grades.Where()
                foreach(var grade in grades)
                {
                    int value = Int32.Parse(grade);
                    int[] values;
                }
            }
          

            //string name = "Terrill";

            //var organized = name.ToLower().OrderBy(n => n).GroupBy(n => n).Select(n => n);

            //foreach (var countOfCharacters in organized)
            //{
            //    Console.Write("" + countOfCharacters.Key + countOfCharacters.Count());
            //}
            //Console.ReadLine();


        }
    }
}
