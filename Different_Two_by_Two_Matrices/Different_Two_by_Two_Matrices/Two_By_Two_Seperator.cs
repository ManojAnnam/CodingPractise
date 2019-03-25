using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Two_by_Two_Matrices
{
    public class Two_By_Two_Seperator
    {
        private int _rows, _columns;
        private int[,] matrix;
        private List<string> twoSizeMatrices=new List<string>();
        public Two_By_Two_Seperator(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            matrix = new int[_rows,_columns];
        }

        public void MatrixInput()
        {
               Console.WriteLine("Enter the matrix elements");
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _columns; j++)
                    {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            int result = Two_By_Two_Strings(matrix);
        }

        public int Two_By_Two_Strings(int[,] matrix)
        {
            for(int i=0;i<(_rows-1);i++)
            {
                for(int j=0;j<(_columns-1);j++)
                {
                    string s = Convert.ToString(matrix[i, j]) + "," + Convert.ToString(matrix[i, (j+1)]) + "," +
                        Convert.ToString(matrix[(i+1), j]) + "," + Convert.ToString(matrix[(i + 1), j+1]);
                    twoSizeMatrices.Add(s);
                }
            }

            return twoSizeMatrices.Distinct().Count(); 
                   
        }

       

    }
}
