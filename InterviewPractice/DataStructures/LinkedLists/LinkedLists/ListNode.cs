using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }

        public static ListNode<int> GetLinkedList(int[] arr)
        {
            ListNode<int> head = null;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                ListNode<int> tmp = new ListNode<int>();
                tmp.value = arr[i];
                tmp.next = head;
                head = tmp;
            }

            return head;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            ListNode<T> curr = this;
            while (curr != null)
            {
                sb.Append(curr.value + " ");
                curr = curr.next;
            }

            return sb.ToString();
        }
    }


}
