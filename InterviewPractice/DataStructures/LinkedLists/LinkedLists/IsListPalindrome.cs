using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class IsListPalindrome
    {

        public bool isListPalindrome(ListNode<int> l)
        {

            ListNode<int> slow = l;
            ListNode<int> fast = l;

            //by the end of this slow points to the half
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }


            if (fast != null)
            {
                slow = slow.next;
            }


            //invert slow
            ListNode<int> inv = null;
            ListNode<int> curr = slow;
            while (curr != null)
            {
                ListNode<int> next = curr.next;
                curr.next = inv;
                inv = curr;
                curr = next;
            }


            while (inv != null)
            {
                if (inv.value != l.value)
                {
                    return false;
                }

                inv = inv.next;
                l = l.next;
            }

            return true;
        }


    }
}
