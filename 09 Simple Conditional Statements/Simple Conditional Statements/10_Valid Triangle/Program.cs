﻿namespace _10_Valid_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Valid Triangle");
            }
            else
            {
                Console.WriteLine("Invalid Triangle");
            }


        }
    }
}