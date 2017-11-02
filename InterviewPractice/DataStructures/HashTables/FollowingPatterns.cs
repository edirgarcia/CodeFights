using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{

//string[] strings0 = { "cat", "dog", "dog" };
//string[] strings1 = { "cat", "dog", "doggy" };
//string[] patterns = { "a", "b", "b" };

//FollowingPatterns fp = new FollowingPatterns();

//Console.Out.WriteLine(fp.areFollowingPatterns(strings0, patterns));
//Console.Out.WriteLine(fp.areFollowingPatterns(strings1, patterns));

    public class FollowingPatterns
    {
       public bool areFollowingPatterns(string[] strings, string[] patterns)
        {

            Dictionary<string, string> stringToPattern = new Dictionary<string, string>();
            Dictionary<string, string> patternToString = new Dictionary<string, string>();

            for (int i = 0; i < strings.Length; i++)
            {
                string s = strings[i];
                //Console.Out.WriteLine(s);
                if (stringToPattern.ContainsKey(s))
                {
                    if (stringToPattern[s] != patterns[i])
                    {
                        return false;
                    }
                }
                else if (patternToString.ContainsKey(patterns[i]))
                {
                    if (patternToString[patterns[i]] != s)
                    {
                        return false;
                    }
                }
                else
                {
                    stringToPattern[s] = patterns[i];
                    patternToString[patterns[i]] = s;
                }

            }

            return true;
        }


    }
}
