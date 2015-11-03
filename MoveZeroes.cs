/*

Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].

Note:
You must do this in-place without making a copy of the array.
Minimize the total number of operations.

将数组中的“0”全都移动到数组末端

遍历数组，将当前位置i之前存在“零”的个数记为k，将位置i和位置i-k的数字进行交换

*/


public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int zero = 0;
        int a = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                zero++;
            }
            else
            {
                a = nums[i - zero];
                nums[i - zero] = nums[i];
                nums[i] = a;
            }
        }  
    }
}
