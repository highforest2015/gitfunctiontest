using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex20201121_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am starting to program in C#.");
            int aNumber = 8;
            var anotherNumber = 9;
            Console.WriteLine(aNumber);
            Console.WriteLine(anotherNumber);
            string firstPartOfSentence = "I am starting to program ";
            string secondPartOfSentence = "in C#.";
            Console.WriteLine("The whole sentence is:\" " + firstPartOfSentence + secondPartOfSentence + "\"");
            // Unicode characters, in this case Greek beta
            Console.WriteLine("If the font knows, here is Greek beta: \u03B2");
            // I prefer specifying "Enter" in more human form
            Console.WriteLine("First line" + Environment.NewLine + "Second line");
            // Backslashes themselves need to be doubled
            Console.WriteLine("Path to desktop on my computer: " + "C:\\Users\\ vystavel\\Desktop");
            // Bob Dylan...
            Console.WriteLine(@"
Yes, and how many times
can a man turn his head
and pretend
that he just doesn't see?
");
            // Pay special attention when mixing texts with numbers!
            Console.WriteLine(
            @"Senior math test
==================
One and one is:");
            Console.WriteLine("a) " + 1 + 1);
            Console.WriteLine("b) " + (1 + 1));
            Console.WriteLine("c) " + "mostly fun");

            string message;
            message = "A Short Message!";
            Console.WriteLine(message);

            // IN CODE, decimal separator is always DOT regardless of computer language settings
            var piApproximately = 3.14;
            // Pi is already available in C#
            double piMorePrecisely = Math.PI;
            // Decimal numbers have always limited precision
            double notCompletelyOne = 0.999999999999999999;
            // Outputs
            Console.WriteLine("Pi value from our code: " + piApproximately);
            Console.WriteLine("Pi value from C#: " + piMorePrecisely);
            Console.WriteLine("This should not be exact one: " + notCompletelyOne);
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            System.DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;
            DateTime TenDaysLater = DateTime.Now.AddDays(10);
            Console.WriteLine(TenDaysLater.ToString());
            Console.WriteLine("今天是：" + year + "年" + month + "月" + day + "日, " + dayOfWeek);

            // Displaying components of Environment object
            Console.WriteLine("Device name: " + Environment.MachineName);
            Console.WriteLine("64-bit system: " + Environment.Is64BitOperatingSystem);
            Console.WriteLine("User name: " + Environment.UserName);
            Console.ReadLine();
        }
    }
}
