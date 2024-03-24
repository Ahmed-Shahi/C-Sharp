using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ahmed Shahi");
            Console.WriteLine("BSE-23F-110");
            Console.WriteLine("\n");
            int age = 0;
            Console.Write("Please Enter Your Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"User Age: {age}");
            Console.ReadKey();

        }
    }
}
