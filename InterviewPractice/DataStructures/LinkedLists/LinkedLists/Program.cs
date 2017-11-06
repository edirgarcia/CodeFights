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
            Merge m = new Merge();
            ListNode<int> l1 = ListNode<int>.GetLinkedList(new int[] {1,1,2,4});
            ListNode<int> l2 = ListNode<int>.GetLinkedList(new int[] { 0, 3, 5 });

            Console.Out.WriteLine(m.mergeTwoLinkedLists(l1, l2));


            return 0;
        }
    }
}
