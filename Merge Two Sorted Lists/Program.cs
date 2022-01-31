using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode();
            ListNode tail = head;

            while (l1 != null & l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    tail.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    tail.next = l2;
                    l2 = l2.next;
                }
                tail = tail.next;
            }
            tail.next = l1 == null ? l2 : l2;

            return head.next;
        }

        
    }
}
