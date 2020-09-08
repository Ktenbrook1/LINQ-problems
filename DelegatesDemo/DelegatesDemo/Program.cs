using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "mike";
            int age = 32;
            var isAwesome = true;

            

            var movieTheDeparted = new { title = "The Departed" };
            
            Printer printer = new Printer();
            //printer.Execute();
            //printer.TestDelegate();

            //*****************************************************************************************
            
            Calculator calculator = new Calculator();
            NewCalculator newCalculator = new NewCalculator();

            //calculator.PrintResult(10, 20, newCalculator.SetSum);

            //calculator.PrintResult(10, 20, calculator.MultiplyTwoNumbers);

            //*****************************************************************************************

            List<int> grades = new List<int>() { 100, 61, 97, 85, 55, 89 };

            IEnumerable<int> result = GradeChecker.CheckGrades(grades, GradeChecker.LessThanSeventy);

            IEnumerable<int> result1 = GradeChecker.CheckGrades(grades, GradeChecker.GreaterThanSeventy);
            foreach (int grade in result)
            {
                Console.WriteLine(grade);
            }

            //*****************************************************************************************

            MovieLibrary movieLibrary = new MovieLibrary();
            List<Movie> movies = movieLibrary.GetMovies();

            List<Movie> hourAndAHalfMovieRunTime = movies.FindAll(m => m.runTime > 90);
            foreach (var movie in hourAndAHalfMovieRunTime)
            {
                Console.WriteLine(movie.title);
            }

            //*****************************************************************************************

            //The Departed, Inception, The Dark Knight

            //var collectionOfMovies = movies.Where(m => m.runTime >= 90).OrderBy(m => m.title).Select(m => m.title).ToList();

            var ninetyMinuteMovies = movies.Where(m => m.runTime >= 90).ToList(); //The Departed object, The Dark Knight object

            var moviesSorted = ninetyMinuteMovies.OrderBy(m => m.title).ToList(); //The Dark Knight object, The Departed object

            var movieTitles = moviesSorted.Select(m => m.title).ToList(); //"The Dark Knight", "The Departed"
            
        }


        //m => m.runTime > 90
        public bool CheckEachMovie(Movie m)
        {
            if(m.runTime > 90)
            {
                return true;
            }
            return false;
        }
    }
}
