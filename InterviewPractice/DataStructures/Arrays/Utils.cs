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
    }
}
