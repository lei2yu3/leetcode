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
