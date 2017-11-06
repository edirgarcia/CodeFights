using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Merge
    {
        public ListNode<int> mergeTwoLinkedLists(ListNode<int> l1, ListNode<int> l2)
        {
            ListNode<int> ret = null;
            ListNode<int> prev = null;

            while (l1 != null || l2 != null)
            {

                //Console.Out.WriteLine(l1 != null);
                ListNode<int> toAdd = new ListNode<int>();
                if (l1 == null)
                {
                    toAdd.value = l2.value;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    toAdd.value = l1.value;
                    l1 = l1.next;
                }
                else
                {
                    if (l1.value < l2.value)
                    {
                        toAdd.value = l1.value;
                        l1 = l1.next;
                    }
                    else
                    {
                        toAdd.value = l2.value;
                        l2 = l2.next;
                    }
                }

                if (ret == null)
                {
                    ret = toAdd;
                }

                if (prev != null)
                {
                    prev.next = toAdd;
                }

                prev = toAdd;

                //Console.Out.WriteLine(toAdd.value);

            }

            return ret;
        }
    }
}
