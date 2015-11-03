/*

Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.

Here are few examples.
[1,3,5,6], 5 → 2
[1,3,5,6], 2 → 1
[1,3,5,6], 7 → 4
[1,3,5,6], 0 → 0

有序数列的查找。
若找到则返回位置，若未找到则返回可以被插入的位置。
binary search may be better

*/


class Solution 
{
public:
    int searchInsert(int A[], int n, int target) 
    {
        for(int i = 0; i < n; i ++)
        {
            if(target <= A[i])
                return i;
            if(i == n-1)
                return n;
        }
    }
};
