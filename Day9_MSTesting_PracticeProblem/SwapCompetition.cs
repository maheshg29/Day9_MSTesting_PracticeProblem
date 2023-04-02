using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_MSTesting_PracticeProblem
{
    public class SwapCompetition
    {
        public List<int> Competition()
        {
            List<int> nextRoun = new List<int>();
            Console.WriteLine("Please Enter How may group take part of competition ");
            int groupCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < groupCount; i++)
            {
                Console.WriteLine("Group {0} player 1 insert your word", i + 1);
                string player1 = Console.ReadLine();
                Console.WriteLine("Group {0} player 2 insert your word", i + 1);
                string player2 = Console.ReadLine();
                char[] playerChar = player1.ToCharArray();
                char[] playerChar2 = player2.ToCharArray();
                bool charContains = true;
                if (playerChar.Length == playerChar2.Length)
                {
                    for (int j = 0; j < playerChar.Length; j++)
                    {
                        if (!playerChar.Contains(playerChar2[j]))
                        {
                            Console.WriteLine("second player's word not formed by rearranging the letters in the first player's word.\n " +
                            " So {0} group is not eligible for the next round", i + 1);
                            charContains = false;
                            break;
                        }
                    }
                    if (charContains)
                    {
                        nextRoun.Add(i + 1);
                    }
                }
                else
                {
                    Console.WriteLine("second player's word not formed by rearranging the letters in the first player's word.\n " +
                              " So {0} group is not eligible for the next round", i + 1);
                    charContains = false;
                    break;
                } 
            }
            return nextRoun;
        }
    }
}
