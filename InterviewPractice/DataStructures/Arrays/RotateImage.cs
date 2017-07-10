using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class RotateImage
    {

        publicint[][] rotateImage(int[][] a)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                for (int j = i; j < a.Length - i - 1; j++)
                {
                    rotatePoint(a, i, j);
                }
            }

            return a;
        }


        private void rotatePoint(int[][] a, int i, int j)
        {
            int c = a[i][j];
            a[i][j] = a[a.Length - 1 - j][i];
            a[a.Length - 1 - j][i] = a[a.Length - 1 - i][a.Length - 1 - j];
            a[a.Length - 1 - i][a.Length - 1 - j] = a[j][a.Length - 1 - i];
            a[j][a.Length - 1 - i] = c;
        }
    }
}
