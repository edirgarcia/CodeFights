using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class FirstDuplicate
    {

        //learning:  you could use the same structure given the right  restrictions to convey extra info, 
        //here the *-1 means you've seen it in the same array structure

        /*
         *             
        FirstDuplicate fd = new FirstDuplicate();
        fd.firstDuplicate(new int[] { 8, 4, 6, 2, 6, 4, 7, 9, 5, 8 });
         * 
         * */

        public int firstDuplicate(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int c = Math.Abs(a[i]) - 1;
                if (a[c] >= 0)
                {
                    a[c] *= -1;
                }
                else
                {
                    return Math.Abs(a[i]);
                }
            }
            return -1;
        }

        /*
        int firstDuplicate(int[] a)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (set.Contains(a[i]))
                {
                    return a[i];
                }
                else
                {
                    set.Add(a[i]);
                }
            }

            return -1;
        }
        */
    }
}
