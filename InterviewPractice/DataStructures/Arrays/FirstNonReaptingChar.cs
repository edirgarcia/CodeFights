using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{


    /*
     * 
            FirstNonReaptingChar f = new FirstNonReaptingChar();
            f.firstNotRepeatingCharacter("bcccccccccccccyb");
     */
    class FirstNonReaptingChar
    {
        public char firstNotRepeatingCharacter(string s)
        {
            Dictionary<char, int> set = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!set.ContainsKey(s[i]))
                {
                    set.Add(s[i], 1);
                }
                else
                {
                    set[s[i]]++;
                }
            }

            for(int i = 0; i < s.Length; i++ )
            {
                if(set[s[i]] == 1)
                {
                    return s[i];
                }
            }

            return '_';
        }

    }
}
