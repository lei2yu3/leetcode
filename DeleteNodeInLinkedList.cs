/*

Write a function to delete a node (except the tail) in a singly linked list, given only access to that node.

Supposed the linked list is 1 -> 2 -> 3 -> 4 and you are given the third node with value 3, the linked list should become 1 -> 2 -> 4 after calling your function.

删除链表中指定的节点，只给出该节点。

用下一个节点的值代替前一个节点的值
(!!THIS PROBLEM SUCKS!!)

*/


public class Solution 
{
    public void DeleteNode(ListNode node) 
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}
