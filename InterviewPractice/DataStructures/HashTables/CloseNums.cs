using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class CloseNums
    {
       public bool containsCloseNums(int[] nums, int k)
        {
            Dictionary<int, int> latestIdx = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (latestIdx.ContainsKey(nums[i]))
                {
                    //Console.Out.WriteLine((latestIdx[nums[i]] - i));
                    if (Math.Abs((latestIdx[nums[i]] - i)) <= k)
                    {
                        return true;
                    }
                    else
                    {
                        latestIdx[nums[i]] = i;
                    }
                }
                else
                {
                    latestIdx[nums[i]] = i;
                }
            }

            return false;
        }

    }
}
