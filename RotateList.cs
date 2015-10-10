/*

Given a list, rotate the list to the right by k places, where k is non-negative.

For example:
Given 1->2->3->4->5->NULL and k = 2,
return 4->5->1->2->3->NULL.

循环右移链表
获取链表长度length，将链表首尾相连形成环
根据k值，重新设置head

*/


public class Solution {
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || k <= 0)
            return head;

        // get list length
        int lenth = 1;
        ListNode ln = head;
        while (ln.next != null)
        {
            ln = ln.next;
            lenth++;
        }

        // set list to circle
        ln.next = head;
        
        // get position of new head
        k = lenth - k % lenth;
        if (k == 0) return head;

        for (int j = 0; j < k; j++)
        {
            ln = ln.next;
        }
        
        // break list
        head = ln.next;
        ln.next = null;

        return head;
    }
}
