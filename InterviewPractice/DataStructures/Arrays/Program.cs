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
            IsCryptSolution ics = new IsCryptSolution();
            bool ret = ics.isCryptSolution(new string[3] { "TEN", "TWO", "ONE" }, Utils.GetCryparithm());
        }
    }
}
