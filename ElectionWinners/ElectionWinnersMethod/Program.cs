using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionWinnersMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] votes = {5,1,3,4,1};
            int k = 0;
            int result = electionsWinners(votes, k);
            Console.WriteLine();
        }

        private static int electionsWinners(int[] votes, int k)
        {
            int presentMax = votes.Max();
            int count = 0;
            for (int i =0;i<votes.Length;i++)
            {
                if(votes[i]+k > presentMax)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                return count;
            }
            else
            {
                var nMax = (votes.Where(s => s == presentMax)).Count();
                if(nMax==1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
        }
    }
}
