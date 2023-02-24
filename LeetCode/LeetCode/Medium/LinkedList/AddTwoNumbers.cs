using LeetCode.DataStructures;

namespace LeetCode.Medium.LinkedList;

public class AddTwoNumbersTask
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var tempVal = 0;
        var head = l1;
        while (l1 != null)
        {
            var l2value = l2?.val ?? 0;
            var ans = l1.val + tempVal+ l2value;
            l1.val = ans % 10;
            tempVal = ans / 10;

            if (l1.next == null && l2?.next != null)
            {
                l1.next = l2.next;
                l1 = l1.next;
                l2 = null;
                continue;
            }
            
            l2 = l2?.next;
            if (l1.next == null && tempVal == 1)
            {
                l1.next = new ListNode(1);
                l1 = l1.next;
            }

            l1 = l1.next;
        }
        
        return head;
    }

    public void Test()
    {

        var h1 = new ListNode(2)
        {
            next = new ListNode(4)
            {
                next = new ListNode(9)
            }
        };
        var h2 = new ListNode(5)
        {
            next = new ListNode(6)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(9)
                }
            }
        };
        AddTwoNumbers(h1, h2);
    }
}