using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteDigitMethod
{
    public class MaximumNumberFinder
    {
        int inputDigit = 0;
        public MaximumNumberFinder(int input)
        {
            inputDigit = input;
        }

        internal int DeleteDigit()
        {
            int[] splitDigits = inputDigit.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
            int max = 0;
            for (int i = 0; i < splitDigits.Length; i++)
            {
                var tempNumber = Convert.ToInt32(string.Join(string.Empty,(splitDigits.Where((c,j) => j != splitDigits[i]).ToArray())));
                if(tempNumber>max)
                {
                    max = tempNumber;
                }
               
            }
            return max;
        }
    }
}
