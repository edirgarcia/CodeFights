using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Sudoku
    {
        public bool sudoku2(char[][] grid)
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<char> set = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    if (grid[i][j] != '.')
                    {
                        if (set.Contains(grid[i][j]))
                        {
                            return false;
                        }
                        else
                        {
                            set.Add(grid[i][j]);
                        }
                    }
                }

                set = new HashSet<char>();

                for (int j = 0; j < 9; j++)
                {
                    if (grid[j][i] != '.')
                    {
                        if (set.Contains(grid[j][i]))
                        {
                            return false;
                        }
                        else
                        {
                            set.Add(grid[j][i]);
                        }
                    }
                }

            }


            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    if (!CheckSubGrid(grid, i, j))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool CheckSubGrid(char[][] grid, int x, int y)
        {
            HashSet<char> set = new HashSet<char>();
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    if (grid[i][j] != '.')
                    {
                        if (set.Contains(grid[i][j]))
                        {
                            return false;
                        }
                        else
                        {
                            set.Add(grid[i][j]);
                        }
                    }
                }
            }

            return true;
        }
    }
}
