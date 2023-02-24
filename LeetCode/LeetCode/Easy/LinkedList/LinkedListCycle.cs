using LeetCode.DataStructures;

namespace LeetCode.Easy.LinkedList;

public class LinkedListCycle
{
    public bool HasCycle(ListNode head)
    {
        if (head == null)
            return false;
        var slow = head;
        var fast = head.next;
        while (fast != null && fast.next != null)
        {
            if (slow == fast)
                return true;
            slow = slow.next;
            fast = fast.next.next;
        }

        return false;
    }

    public void Test()
    {
    }
}