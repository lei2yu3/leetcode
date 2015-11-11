/*

You are given two linked lists representing two non-negative numbers. 
The digits are stored in reverse order and each of their nodes contain a single digit. 
Add the two numbers and return it as a linked list.

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8

大整数加法，按位相加，大于9进位

*/


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        if (l1 == null && l2 == null)
            return null;
        if (l1 == null)
            return l2;
        if (l2 == null)
            return l1;

        ListNode ret = new ListNode(0);
        ListNode t = ret;

        int carry = 0;
        
        // 遍历两个链表，将各个位数相加，大于9进位
        for (ListNode i = l1, j = l2; i != null || j != null; )
        {
            int sum = 0;
            
            // 链表数位不等时，则只遍历数位较长的，
            if (i == null)
            {
                sum = j.val + carry;
                j = j.next;
            }
            else if (j == null)
            {
                sum = i.val + carry;
                i = i.next;
            }
            else
            {
                sum = i.val + j.val + carry;
                i = i.next;
                j = j.next;
            }

            carry = sum > 9 ? 1 : 0; // 大于9则进位
            sum %= 10;  // 结果取10的余数

            t.next = new ListNode(sum);
            t = t.next;
        }

        // 向最高位进位1
        if (carry == 1)
            t.next = new ListNode(1);

        ret = ret.next;

        return ret;
    }
}
