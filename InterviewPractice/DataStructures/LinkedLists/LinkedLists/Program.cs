using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {

        static int Main(string[] args)
        {

            ListNode<int> l = ListNode<int>.GetLinkedList(new int[] { 1, 2, 3, 2, 1 });

            IsListPalindrome ilp = new IsListPalindrome();
            ilp.isListPalindrome(l);

            return 0;
        }
    }
}
