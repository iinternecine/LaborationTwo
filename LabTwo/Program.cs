﻿using System;

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

        static double InputA()
        {
            Console.Write("Введите A: ");
            return Convert.ToDouble(Console.ReadLine());
        }

    }
}