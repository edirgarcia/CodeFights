using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class FirstDuplicate
    {
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
    }
}
