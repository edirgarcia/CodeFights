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
    }
}
