﻿namespace _08_Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if((num >= 100 && num <= 200) || num == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}