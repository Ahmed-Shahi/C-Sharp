using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Add
    {
    public int c;

          public void addition()
        {
            Console.WriteLine("First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
             c = a + b;
            Console.WriteLine("The sum of {0} & {1} is : {2}", a, b, c);
            Console.ReadKey();            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Add Sum = new Add();
                Sum.addition();
            }
            while (i=c);
            }
    }
}
