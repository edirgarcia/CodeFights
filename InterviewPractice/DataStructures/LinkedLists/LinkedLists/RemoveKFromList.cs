using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class RemoveKFromList
    {
        ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            ListNode<int> curr = l;

            if (curr == null)
            {
                return null;
            }


            while (curr.next != null)
            {
                if (curr.next.value == k)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }

            if (l.value == k)
            {
                return l.next;
            }
            else
            {
                return l;
            }


        }

    }
}
