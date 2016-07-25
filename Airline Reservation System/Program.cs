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
namespace AirlineReservationSystem
{

    class Program
    {
        private static List<string> _seatingChart;
        private static List<string> _assignedSeats;

        static void Main(string[] args)
        {
            _seatingChart = new List<string>();
            _assignedSeats = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                _seatingChart.Add("First Class");
            }
            for (int i = 0; i < 5; i++)
            {
                _seatingChart.Add("Economy");
            }

            DisplayMenu();
        }
        static void DisplayMenu()
        {
            string choose;
            do
            {
                Console.WriteLine("   1.   First class");
                Console.WriteLine("   2.   Economy");
                Console.WriteLine("   3.   Exit");

                Console.Write("   Choose an option: ");
                choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        FirstClass();
                        break;
                    case "2":
                        Economy();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("   Invaid choice");
                        break;
                }
            } while (choose != "3");
        }
        static void FirstClass()
        {
            if (_seatingChart.Remove("First Class"))
            {
                _assignedSeats.Add("First Class");
                Console.WriteLine("You got a First Class seat.");
            }
            else
            {
                Console.Write("First class is full, do you want Economy?");
                string answer = Console.ReadLine();
                if (answer == "yes" && _seatingChart.Remove("Economy"))
                {
                    _assignedSeats.Add("Economy");
                    Console.WriteLine("You got an Economy seat.");
                }
                else
                {
                    Console.WriteLine("Next flight leaves in 3 hours.");
                }
            }
        }
        static void Economy()
        {
            if (_seatingChart.Remove("Economy"))
            {
                _assignedSeats.Add("Economy");
                Console.WriteLine("You got an Economy seat.");
            }
            else
            {
                Console.Write("Economy is full, do you want First Class?");
                string answer = Console.ReadLine();
                if (answer == "yes" && _seatingChart.Remove("First Class"))
                {
                    _assignedSeats.Add("First Class");
                    Console.WriteLine("You got a First Class seat.");
                }
                else
                {
                    Console.WriteLine("Next flight leaves in 3 hours.");
                }
            }
        }

        private static int Find(List<string> list, string item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == item)
                {
                    return i;
                }

            }
            return -1;
        }
    }
}
