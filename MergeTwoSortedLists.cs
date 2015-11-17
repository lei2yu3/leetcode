/*

Merge two sorted linked lists and return it as a new list. 
The new list should be made by splicing together the nodes of the first two lists.

*/


public class Solution 
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
    {
        if (l1 == null)
            return l2;
        if (l2 == null)
            return l1;

        ListNode ret = new ListNode(0);
        ListNode c = ret;

        while (l1 != null && l2 != null)
        {
            if (l1.val > l2.val)
            {
                c.next = new ListNode(l2.val);
                c = c.next;
                l2 = l2.next;
            }
            else
            {
                c.next = new ListNode(l1.val);
                c = c.next;
                l1 = l1.next;
            }
        }

        if (l1 == null)
            c.next = l2;
        else if (l2 == null)
            c.next = l1;

        return ret = ret.next;
    }
}
