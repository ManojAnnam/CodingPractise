using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxConsecutiveImprovised
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 2, 4 };
            int k = 3;
            int j = maxSum(a, k);
          
            Console.ReadLine();
        }
        private static int maxSum(int[] inputArray, int k)
        {
            int temp1 = 0;int result = 0;
            for(int i = 0; i < k; i++)
            {
                temp1 += inputArray[i];
            }
            if(temp1>result)
            {
                result = temp1;
            }
            for(int i=k; i<=(inputArray.Length-1);i++)
            {
                temp1 = temp1 + inputArray[i] - inputArray[i-k];
                if (temp1 > result)
                {
                    result = temp1;
                }
            }
           
            return result;
        }
    }
}
