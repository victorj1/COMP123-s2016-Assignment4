using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Name: Victor Jdanovitch
Date Modified: 07/24/2016
Student#: 300869472
Description: Assignment 4 - Array and List Practice
*/
namespace DiceRollingSimulation
{  
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] tally = new int[13];
            for (int counter = 0; counter < 36000; counter++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;
                tally[sum]++;
            }
            Console.WriteLine("   {0,-3}      {1,-10}", "Sum", "Count");
            Console.WriteLine("   --------------------------------");

            for (int counter = 2; counter < 13; counter++)
            {
                Console.WriteLine("   {0,-3} ---> {1,-10}", counter, tally[counter]);
                Console.WriteLine();
            }

        }
    }
}
