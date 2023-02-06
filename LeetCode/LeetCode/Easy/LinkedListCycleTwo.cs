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
        var f = new ListNode(3);
        var s =  new ListNode(2);
        var t = new ListNode(0);
        var fo = new ListNode(4);

        f.next = s;
        s.next = t;
        t.next = fo;
        fo.next = s;

        var ans = DetectCycle(f);
        Console.WriteLine(ans.val);
    }
}