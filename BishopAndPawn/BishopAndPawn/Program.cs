using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BishopAndPawn
{
    class Program
    {
        static void Main(string[] args)
        {
            string bishop = string.Empty;
            string pawn = string.Empty;
            bishop = Console.ReadLine();
            pawn = Console.ReadLine();
            Console.WriteLine(bishopAndPawn(bishop, pawn));
            Console.ReadLine();
        }

        private static bool bishopAndPawn(string bishop, string pawn)
        {
            int bishopInt = 0;
            bishopInt = bishop[0];
            int biInt = bishopInt - 96;
            bishopInt = Convert.ToInt32(bishop[1].ToString());
            int pawnInt = 0;
            pawnInt = pawn[0];
            int paInt = pawnInt - 96;
            pawnInt = Convert.ToInt32(pawn[1].ToString()); 
            if (bishopInt == pawnInt || biInt == paInt)
            {
                return false;
            }
            else if (paInt > biInt && pawnInt > bishopInt)
            {
                return IncreasingColumnIncreasingRow(biInt, bishopInt, paInt, pawnInt);
            }
            else if (paInt < biInt && pawnInt < bishopInt)
            {
                return DecreasingColumnDecreasingRow(biInt, bishopInt, paInt, pawnInt);
            }
            else if (paInt > biInt && pawnInt < bishopInt)
            {
                return IncreasingColumnDecreasingRow(biInt, bishopInt, paInt, pawnInt);
            }
            else if (paInt < biInt && pawnInt > bishopInt)
            {
                return DecreasingColumnIncreasingRow(biInt, bishopInt, paInt, pawnInt);
            }

            return false;
        }

        private static bool DecreasingColumnIncreasingRow(int biInt, int bishopInt, int paInt, int pawnInt)
        {
            while (biInt >=1  && bishopInt <= 8)
            {
                biInt--;
                bishopInt++;
                if (biInt == paInt && bishopInt == pawnInt)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IncreasingColumnDecreasingRow(int biInt, int bishopInt, int paInt, int pawnInt)
        {
            while (biInt <= 8 && bishopInt >= 1)
            {
                biInt++;
                bishopInt--;
                if (biInt == paInt && bishopInt == pawnInt)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool DecreasingColumnDecreasingRow(int biInt, int bishopInt, int paInt, int pawnInt)
        {
            while (biInt >= 1 && bishopInt <= 8)
            {
                biInt--;
                bishopInt--;
                if (biInt == paInt && bishopInt == pawnInt)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IncreasingColumnIncreasingRow(int biInt, int bishopInt, int paInt, int pawnInt)
        {
            while(biInt<=8 && bishopInt<=8)
            {
                biInt++;
                bishopInt++;
                if (biInt == paInt && bishopInt == pawnInt)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
