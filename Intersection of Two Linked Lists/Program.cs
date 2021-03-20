using System;

namespace Intersection_of_Two_Linked_Lists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
  }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world...");
        }


        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA==null||headB==null)
            {
                return null;
            }
            ListNode pointerA = headA;
            ListNode pointerB = headB;

            while (pointerA!=pointerB)
            {
                pointerA = pointerA == null ? headB :  pointerA.next;

                pointerB = pointerB == null ? headA : pointerB.next;
            }
            return pointerA;
        }
    }
}
