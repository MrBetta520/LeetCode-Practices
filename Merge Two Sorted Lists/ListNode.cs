using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    class ListNode
    {
        public int val { get; set;}
        
        public ListNode next { get; set;}
        
        public ListNode (int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
