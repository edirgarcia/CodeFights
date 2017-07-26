using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Utils
    {
        public static void PrintArray(int[][] arr)
        {
            for(int i = 0; i< arr.Length; i++)
            {
                for(int j = 0; j < arr[0].Length; j++)
                {
                    Console.Out.Write(arr[i][j]);
                }
                Console.Out.WriteLine();
            }
        }



        public static int[][] GetSampleSquareMatrix(int l)
        {
            int[][] ret = new int[l][];
            int c = 1;

            for(int i = 0; i< ret.Length; i++)
            {
                ret[i] = new int[l];
                for(int j =0; j< ret.Length; j++)
                {
                    ret[i][j] = c++;
                }
            }
            return ret;
        }

        public static char[][] GetSampleSudoku()
        {
            return new char[9][]
         { new char[9] {'.', '.', '.', '1', '4', '.', '.', '2', '.'},
         new char[9] {'.','.','6','.','.','.','.','.','.'},
         new char[9] {'.','.','.','.','.','.','.','.','.'},
         new char[9] {'.','.','1','.','.','.','.','.','.'},
         new char[9] {'.','6','7','.','.','.','.','.','9'},
         new char[9] {'.','.','.','.','.','.','8','1','.'},
         new char[9] {'.','3','.','.','.','.','.','.','6'},
         new char[9] {'.','.','.','.','.','7','.','.','.'},
         new char[9] {'.','.','.','5','.','.','.','7','.'}};

        }

        public static char[][] GetCryparithm()
        {
            return new char[][]
            {
                new char[2]{'O','1'},
                new char[2]{'T','0'},
                new char[2]{'W','9'},
                new char[2]{'E','5'},
                new char[2]{'N','4'}
            };
        }
    }
}
