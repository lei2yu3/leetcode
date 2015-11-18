/*

Given a linked list, remove the nth node from the end of list and return its head.

For example,

   Given linked list: 1->2->3->4->5, and n = 2.

   After removing the second node from the end, the linked list becomes 1->2->3->5.
   
Note:
Given n will always be valid.
Try to do this in one pass.

删除链表中倒数第n个节点

让fast指向正数第n个节点，再让fast和slow同时向后移动，直到fast.next为空，于是slow.next就是倒数第n个节点

*/


public class Solution 
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        ListNode fast = head;
        ListNode slow = head;

        while (n-- > 0)
            fast = fast.next;

        if (fast == null)
            return head.next;

        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;

        return head;
    }
}
