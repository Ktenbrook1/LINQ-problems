﻿using System;
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

            List<string> names = new List<string>() { "Mike", "Charles", "Nevin", "David", "Mike", "Tony", "Brett"};
            var distinctNames = names.Distinct();
            foreach (var name in distinctNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
