namespace LeetCode.Easy;

public class RemoveDuplicatesFromSortedList
{
    public ListNode Solution(ListNode head)
    {
        var start = head;

        Clear(head);
        
        return start;

        void Clear(ListNode head)
        {
            if(head==null)
                return;
            
            if(head.val == head.next?.val)
                head.next = head.next.next;
            else
                head = head.next;
                
            Clear(head);
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