﻿namespace _05_Numbers_From_1_to_N_over_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i =1;i <= n; i += 3)
            {
                Console.WriteLine(i);

            }
        }
    }
}