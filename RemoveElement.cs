/*

Given an array and a value, remove all instances of that value in place and return the new length.

The order of elements can be changed. It doesn't matter what you leave beyond the new length.

移除数组中的指定元素到数组的末尾

类似问题：
https://github.com/lygithub/leetcode/blob/master/MoveZeroes.cs

*/


public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        
        int count = 0;
        int a = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                count++;
            }
            else
            {
                a = nums[i - count];
                nums[i - count] = nums[i];
                nums[i] = a;
            }
        }
        
        return nums.Length - count;
    }
}
