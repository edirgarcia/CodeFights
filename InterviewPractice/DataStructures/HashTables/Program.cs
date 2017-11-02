using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            CloseNums cn = new CloseNums();

            Console.Out.WriteLine(cn.containsCloseNums(new int[] {0, 1, 2, 3, 5, 2}, 3));

            Console.Out.WriteLine(cn.containsCloseNums(new int[] { 0, 1, 2, 3, 5, 2 }, 2));

        }
    }
}
