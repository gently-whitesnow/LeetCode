using LeetCode.DataStructures;

namespace LeetCode.Easy.LinkedList;

public class IntersectionOfTwoLinkedLists
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null||headB==null)
            return null;
        
        var headAStart = headA;
        
        while (headB!=null)
        {
            if (headA == null)
            {
                headA = headAStart;
                headB = headB.next;
            }

            if (headA == headB)
                return headA;

            headA = headA.next;
        }

        return null;
    }
    
    public ListNode getIntersectionNodeBetter(ListNode headA, ListNode headB) {
        //boundary check
        if(headA == null || headB == null) return null;
    
        ListNode a = headA;
        ListNode b = headB;
    
        //if a & b have different len, then we will stop the loop after second iteration
        while( a != b){
            //for the end of first iteration, we just reset the pointer to the head of another linkedlist
            a = a == null? headB : a.next;
            b = b == null? headA : b.next;    
        }
    
        return a;
    }
}