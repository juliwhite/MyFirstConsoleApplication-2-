using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication_2_
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            //Crate two variables: name and location.
            string name = "Julieta White";
            string location = "Idaho-USA";

            // Create current date.
            DateTime today = DateTime.Now;

            // Create a variable of christmas date (12-25-2013).
            DateTime christmasDate = Convert.ToDateTime("12-25-2023").Date;

            // Substract the christmasDate and today to get days until christmas.
            TimeSpan daysUntilChristmas = christmasDate.Subtract(today);

            Console.WriteLine($"\n My name is, {name}, I live in, {location}.");
            Console.WriteLine($" Today is, {today.ToString("MM-dd-yyyy")}.");
            Console.WriteLine($" {daysUntilChristmas.Days} days until Christmas.");

            // Add program from section 2.1 C# "Programming Yellow Book" by Rob Miles.
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadKey(true);

      
        }
    }
}
