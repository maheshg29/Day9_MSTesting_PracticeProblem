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
                " 1. Purchase List Problem\n" +
                " 2. Swap Competition");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please Enter all purchase Price List in a single line");
                    string inputPrices = Console.ReadLine();
                   
                    Purches purches = new Purches();
                  
                    List<string> onlyone=purches.OnlyOnce(inputPrices);
                    foreach (string s in onlyone)
                    {
                        Console.WriteLine("{0} Price Item purchase only one",s);
                    }

                    List<string> multipleOccurance = purches.moreThanOne(inputPrices);
                    foreach (string s in multipleOccurance)
                    {
                        Console.WriteLine("{0} Price Item purchase more than one", s);
                    }
                    break;

                    case 2:
                    SwapCompetition swapCompetition = new SwapCompetition();
                    List<int> nextRound=swapCompetition.Competition();
                    foreach (int s in nextRound)
                    {
                        Console.WriteLine("Group {0} is Eligible for next Round ", s);
                    }

                    break;

                default:
                    Console.WriteLine("Please Enter Correct Option");
                    break;
            }
        }
    }
}
