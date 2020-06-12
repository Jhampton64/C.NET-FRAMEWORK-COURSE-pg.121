using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int pakW = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (pakW >= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width:");
            int pakWi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the package height:");
            int pakH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the package length:");
            int pakL = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (pakWi + pakH + pakL > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            int combine = pakWi * pakH * pakL * pakW / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $"+ combine);
            Console.WriteLine("Thank you.");
            Console.ReadLine();

        }
    }
}
