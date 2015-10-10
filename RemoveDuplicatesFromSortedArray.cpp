/*

Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.

Do not allocate extra space for another array, you must do this in place with constant memory.

For example,
Given input array A = [1,1,2],

Your function should return length = 2, and A is now [1,2].

除去排序数组中重复的内容，使数组中的内容只出现一次，输出处理之后数组的长度

*/


class Solution {
public:
    int removeDuplicates(int A[], int n) {
        if(n == 0) return 0;
       
        int m = 1;
    
        for(int i = 1; i < n; i++)
        {
            if(A[i-1] != A[i])
            {
                A[m++] = A[i];
            }
        }
    
        return m;
    }
};
