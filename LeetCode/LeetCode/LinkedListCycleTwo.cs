using System;

namespace LeetCode;

public class LinkedListCycleTwo
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
    public ListNode DetectCycle(ListNode head)
    {
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) break;
        }

        if (fast == null || fast.next == null) return null;
        while (head != slow)
        {
            head = head.next;
            slow = slow.next;
        }

        return head;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public void Test()
    {
        Console.WriteLine(DetectCycle(new ListNode(3).next =
            new ListNode(2).next = new ListNode(0).next = new ListNode(-4)));
    }
}