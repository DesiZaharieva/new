﻿namespace _04_Number_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            double result = 0;

           if(op == "+")
            {
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result:f2}");
            }
           else if (op == "-")
            {
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result:f2}");
            }
            else if (op == "*")
            {
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result:f2}");
            }
            else if (op == "/")
            {
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result:f2}");
            }
        }
    }
}