﻿namespace _03_Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double n = double.Parse(Console.ReadLine());
            double sum = 0;

            for(int i = 0;i < n;i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}