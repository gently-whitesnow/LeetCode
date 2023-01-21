using System;

namespace LeetCode.Easy;

public class MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            return list2;
        }
        else if (list2 == null)
        {
            return list1;
        }
        else if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }

    ListNode Solution(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        if (list1.val > list2.val)
            (list1, list2) = (list2, list1);
        
        var first = list1;

        while (list1!=null && list2!=null)
        {
            if (list1.val >= list2.val)
            {
                list1.next = new ListNode(list1.val, list1.next);
                list1.val = list2.val;
                list2 = list2.next;
                continue;
            }
            if (list1.next == null)
            {
                list1.next = list2;
                break;
            }

            list1 = list1.next;
        }
        
        return first;
    }
    
    public void Test()
    {
        // var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        // var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        
        // var list1 = new ListNode(1, null);
        // var list2 = new ListNode(2, null);
        
        // list 1 [-10,-9,-6,-4,1,9,9] 
        // var list1 = new ListNode(-10, new ListNode(-9, new ListNode(-6, new ListNode(-4, new ListNode(1, new ListNode(9, new ListNode(9)))))));
        // list 2 [-5,-3,0,7,8,8]
        // var list2 = new ListNode(-5, new ListNode(-3, new ListNode(0, new ListNode(7, new ListNode(8, new ListNode(8))))));

        // [-10,-8,-8,-7,-5,-5,-1,2,9]
        var list1 = new ListNode(-10, new ListNode(-8, new ListNode(-8, new ListNode(-7, new ListNode(-5, new ListNode(-5, new ListNode(-1, new ListNode(2, new ListNode(9)))))))));
        //[-10,5,5,8]
        var list2 = new ListNode(-10, new ListNode(5, new ListNode(5, new ListNode(8))));
        
        var result = Solution(list1, list2);
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