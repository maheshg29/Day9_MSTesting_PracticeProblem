using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_MSTesting_PracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 9 MS tesing Practice Problem");
            Console.WriteLine("Select any one option for Respective task\n" +
                " 1. Purchase List Problem");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please Enter all purchase Price List in a single line");
                    string inputPrices = Console.ReadLine();
                   // string[] prices = input.Split(' ');
                    Purches purches = new Purches();
                  
                    List<string> onlyone=purches.OnlyOnce(inputPrices);
                    foreach (string s in onlyone)
                    {
                        Console.WriteLine("{0} Price Item purchase only one",s);
                    }
                    break;

                default:
                    Console.WriteLine("Please Enter Correct Option");
                    break;
            }
        }
    }
}
