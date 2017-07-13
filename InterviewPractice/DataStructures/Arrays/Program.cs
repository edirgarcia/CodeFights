using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Sudoku s = new Arrays.Sudoku();
            Console.Out.WriteLine(s.sudoku2(Utils.GetSampleSudoku()));
        }
    }
}
