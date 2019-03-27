using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Naming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names= { "a(1)",
 "a(6)",
 "a",
 "a",
 "a",
 "a",
 "a",
 "a",
 "a",
 "a",
 "a",
 "a"};
            string[] results = fileNaming(names);
            Console.ReadLine();

        }

        private static string[] fileNaming(string[] names)
        {
            for(int i=1;i<names.Length;i++)
            {
                StringBuilder stringBuilder = new StringBuilder(names[i]);

                if(stringExists(names,names[i],i))
                {
                    stringBuilder.Append("(1)");
                    names[i] = stringBuilder.ToString();
                    while(stringExists(names, names[i], i))
                    {                                           
                        int index1 = names[i].LastIndexOf('(');
                        int index2 = names[i].LastIndexOf(')');
                        int appendNumber = FindIndex(names,index1, index2,i);
                        appendNumber++;
                        names[i] = names[i].Substring(0, index1);
                        StringBuilder stringBuilderNew = new StringBuilder(names[i]);
                        stringBuilderNew.Append("(" + appendNumber + ")");
                        names[i] = stringBuilderNew.ToString();
                    }
                }

            }
            return names;
        }

        private static int FindIndex(string[] names,int index1, int index2,int prsentindex)
        {
            string s = string.Empty;
           for(int i=index1+1;i<index2;i++)
            {
                s += names[prsentindex][i];
            }
            return Convert.ToInt32(s);
        }

        private static bool stringExists(string[] names,string name,int index)
        {
            for(int i=0;i<index;i++)
            {
                if(names[i]==name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
