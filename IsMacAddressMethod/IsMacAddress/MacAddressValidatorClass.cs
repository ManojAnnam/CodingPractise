using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IsMacAddress
{
    class MacAddressValidatorClass
    {
       
        public bool IsMacAddress(string macAddressInput)
        {
            Regex onlyHexa = new Regex(@"^[0-9A-F]*$");
            if (macAddressInput.Length==17)
            {
                string[] individualSubStrings = macAddressInput.Split('-');
                if(!individualSubStrings.Any(c => c.Length!=2))
                {
                    if(individualSubStrings.All(d => onlyHexa.IsMatch(d)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
