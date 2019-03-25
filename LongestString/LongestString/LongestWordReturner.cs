using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LongestString
{
   public class LongestWordReturner
    {
        public string FindLongestWord(string input)
        {

            string[] words = Regex.Split(input,@"[^a-zA-Z]+");
            var orderedWords = words.OrderByDescending(w => w.Length).ToArray();
            
            
            return orderedWords[0];
        }
    }
}
