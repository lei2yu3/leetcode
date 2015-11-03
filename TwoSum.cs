/*

Given an array of integers, find two numbers such that they add up to a specific target number.

The function twoSum should return indices of the two numbers such that they add up to the target, 

where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.

You may assume that each input would have exactly one solution.

Input: numbers={2, 7, 11, 15}, target=9
Output: index1=1, index2=2

在数列中找到唯一的一个二元组，使其和为指定值，返回该二元组的index

先对数组进行排序，找出二元组，再在原数组中查找二元组的index

*/


public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] ret = new int[2] { 0, 0 };
        if (nums == null || nums.Length < 2)
        {
            return ret;
        }

        int[] temp = new int[nums.Length];
        Array.Copy(nums, temp, nums.Length);
        Array.Sort(temp);
        
        int i = 0;
        int j = nums.Length - 1;

        while (i < j)
        {
            int sum = temp[i] + temp[j];

            if (sum == target)
                break;

            if (sum < target)
                i++;
            else
                j--;
        }

        for (int m = 0; m < temp.Length; m++)
        {
            if (nums[m] == temp[i]) { ret[0] = m + 1; break; }
        }
        
        for (int n = temp.Length - 1; n >= 0; n--)
        {
            if (nums[n] == temp[j]) { ret[1] = n + 1; break; }
        }

        if (ret[0] > ret[1])
        {
            int t = ret[0];
            ret[0] = ret[1];
            ret[1] = t;
        }

        return ret;
    }
}
