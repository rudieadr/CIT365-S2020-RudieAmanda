using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ///assignment coding
            string nameFull, location, xtoday;
            nameFull = "Amanda Rudie";
            location = "Wentzville, MO";
            Console.WriteLine($"My name is {nameFull}");
            Console.WriteLine($"I live in middle of nowhere {location}");

            DateTime today = DateTime.Now;
            DateTime Xmas = new DateTime(
                today.Month == 12 && today.Day > 25 ?
                today.Year + 1 : today.Year, 12, 25);
            TimeSpan xmasTimespan = Xmas - today;
            xtoday = today.ToShortDateString();
            Console.WriteLine($"Today's date is {xtoday}");
            Console.WriteLine($"Between today and Christmas, there are {xmasTimespan} days");

            ///coding from Yellow Book example 2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Enter a width:  ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter a height:  ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Show's over folks.  Press any key to exit.");
            Console.ReadKey();

        }
    }
}
