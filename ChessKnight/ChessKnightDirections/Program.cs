using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessKnightDirections
{
    class Program
    {
        static void Main(string[] args)
        {
            string cell = Console.ReadLine();
            int res = chessKnight(cell);
            Console.WriteLine();
        }

        private static int chessKnight(string cell)
        {
            int result = 0;
            int column = cell[0];

            int row = Convert.ToInt32(cell[1].ToString());
            if(column-1 >=97)
            {
                if(row+2<=8)
                {
                    result++;
                }
                if (row - 2 >= 1)
                {
                    result++;
                }
            }
            if (column - 2 >= 97)
            {
                if (row + 1 <= 8)
                {
                    result++;
                }
                if (row - 1 >= 1)
                {
                    result++;
                }
            }
            if (column + 1 <= 104)
            {
                if (row + 2 <= 8)
                {
                    result++;
                }
                if (row - 2 >= 1)
                {
                    result++;
                }
            }
            if (column + 2 <= 104)
            {
                if (row + 1 <= 8)
                {
                    result++;
                }
                if (row - 1 >= 1)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
