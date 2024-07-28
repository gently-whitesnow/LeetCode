using System;

namespace LeetCode.Easy.LinkedList;

public class RemoveLinkedListElements
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        if(head == null)
            return null;
        var pointer = head;
        while (pointer.next != null)
        {
            if (pointer.next.val != val)
            {
                pointer = pointer.next;
                continue;
            }

            pointer.next = pointer.next.next;
        }

        return head.val == val ? head.next : head;
    }
    
    public void Test()
    {
        var list = new ListNode(1, new ListNode(2, new ListNode(4)));
        var result =  RemoveElements(list, 2);
        while (result!=null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }
    
    
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}