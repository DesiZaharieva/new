﻿namespace _01_Numbers_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i = i + 1)
            {
                Console.WriteLine(i);

            }
        }
    }
}