using System;

namespace LaborationTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Enter А");
            Console.WriteLine("Enter В");
            Console.WriteLine("Perform the “+” operation");
            Console.WriteLine("Perform the “-” operation");
            Console.WriteLine("Perform the “*” operation");
            Console.WriteLine("Perform the “/” operation");
        }

        static double InputB()
        {
            Console.Write("Enter B: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static double add()
        {
            Console.Write("Perform the “+” operation");
            return Convert.ToDouble(Console.ReadLine());
        }

        static double subtract()
        {
            Console.Write("Perform the “-” operation");
            return Convert.ToDouble(Console.ReadLine());
        }

        static double multiply()
        {
            Console.Write("Perform the “*” operation");
            return Convert.ToDouble(Console.ReadLine());
        }

    }
}
