using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Two_by_Two_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int columns = Convert.ToInt32(Console.ReadLine());
            Two_By_Two_Seperator two_By_Two_Seperator = new Two_By_Two_Seperator(rows, columns);
            two_By_Two_Seperator.MatrixInput();
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
