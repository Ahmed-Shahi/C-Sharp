using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public interface IExampleInterface
    //{
    //    void SomeMethod();

    //}

    //public class ExampleClass : IExampleInterface
    //{
    //    public void SomeMethod()
    //    {
    //        Console.WriteLine("Implementing Successfully!!!");
    //        Console.ReadKey();
    //    }

    //}
    public interface I1
    {
        void show1();
    }
    public interface I2
    {
        void show1();
    }
    

    internal class Program : I1, I2
    {
        void I1.show1()
        {
            Console.WriteLine("INTERFACE 1...........");
        }
        void I2.show1()
        {
            Console.WriteLine("INTERFACE 2...........");
        }
        
        static void Main(string[] args)
        {
            Program obj = new Program();
             ((I1)obj).show1();
             ((I2)obj).show1();

            I1 I1obj = new Program();
            I1obj.show1();

            I2 I2obj = new Program();
            I2obj.show1();

        }
    }
}
