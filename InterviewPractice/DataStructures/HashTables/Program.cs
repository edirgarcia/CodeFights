using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings0 = {"cat", "dog", "dog"};
            string[] strings1 = { "cat", "dog", "doggy" };
            string[] patterns = { "a", "b", "b" };

            FollowingPatterns fp = new FollowingPatterns();
            
            Console.Out.WriteLine(fp.areFollowingPatterns(strings0, patterns));
            Console.Out.WriteLine(fp.areFollowingPatterns(strings1, patterns));

        }
    }
}
