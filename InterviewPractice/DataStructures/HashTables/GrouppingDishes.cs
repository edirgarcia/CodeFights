using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class GrouppingDishes
    {
        public string[][] groupingDishes(string[][] dishes)
        {
            SortedDictionary<string, List<string>> groupedDishes = new SortedDictionary<string, List<string>>(new Lexico());

            for (int i = 0; i < dishes.Length; i++)
            {
                string currentDish = dishes[i][0];
                for (int j = 1; j < dishes[i].Length; j++)
                {
                    if (!groupedDishes.ContainsKey(dishes[i][j]))
                    {
                        groupedDishes[dishes[i][j]] = new List<string>();
                    }

                    groupedDishes[dishes[i][j]].Add(currentDish);
                }
            }


            List<string[]> retArray = new List<string[]>();
            foreach (KeyValuePair<string, List<string>> kvp in groupedDishes)
            {
                if (kvp.Value.Count > 1)
                {
                    kvp.Value.Sort( new Lexico());
                    string[] row = new string[kvp.Value.Count + 1];

                    row[0] = kvp.Key;
                    for (int j = 0; j < kvp.Value.Count; j++)
                    {
                        row[j + 1] = kvp.Value[j];
                    }

                    retArray.Add(row);
                }
            }


            return retArray.ToArray();
        }
    }

    public class Lexico : IComparer<string>
        {
            public int Compare(string left, string right)
            {
                int i = 0;
                while (i < left.Length && i < right.Length)
                {
                    if (left[i] == right[i])
                    {
                        i++;
                    }
                    else if (left[i] < right[i])
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }

                if (left == right)
                {
                    return 0;
                }

                return left.Length > right.Length ? 1 : -1;
            }
        }

}
