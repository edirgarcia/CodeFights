using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{

    //learned that you need to be careful with restrictions,
    //sometimes the best way is to weed them out explicitly
    class IsCryptSolution
    {
        public bool isCryptSolution(string[] crypt, char[][] solution)
        {
            Dictionary<char, int> map = GetMap(solution);
            int a = DecodeWord(crypt[0], map);
            int b = DecodeWord(crypt[1], map);
            int right = DecodeWord(crypt[2], map);

            return a + b == right;
        }

        private Dictionary<char, int> GetMap(char[][] solution)
        {
            Dictionary<char, int> ret = new Dictionary<char, int>();

            for (int i = 0; i < solution.Length; i++)
            {
                ret.Add(solution[i][0], Int32.Parse(solution[i][1].ToString()));
            }
            return ret;
        }

        private int DecodeWord(string s, Dictionary<char, int> map)
        {
            int sum = 0;
            int powIndx = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sum += map[s[i]] * (Int32)Math.Pow(10, powIndx++);
            }

            if (s.Length > 1 && map[s[0]] == 0)
                return -1;

            return sum;
        }
    }
}
