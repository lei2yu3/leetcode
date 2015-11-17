/*

Remove all elements from a linked list of integers that have value val.

Example
Given: 1 --> 2 --> 6 --> 3 --> 4 --> 5 --> 6, val = 6
Return: 1 --> 2 --> 3 --> 4 --> 5

*/



public class Solution 
{
    public ListNode RemoveElements(ListNode head, int val) 
    {
        ListNode pre = new ListNode(0);
        pre.next = head;
        ListNode node = pre;
    
        while (node.next != null)
        {
            if (node.next.val == val) 
                node.next = node.next.next;
            else 
                node = node.next;
        }
        
        return pre.next;    
    }
}



public class AnotherSolution 
{
    public ListNode RemoveElements(ListNode head, int val) 
    {
        if (head == null) return null;
        head.next = RemoveElements(head.next, val);
        return head.val == val ? head.next : head;
    }
}
