/*

Given an array S of n integers, are there elements a, b, c, and d in S such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.

Note:
Elements in a quadruplet (a,b,c,d) must be in non-descending order. (ie, a ≤ b ≤ c ≤ d)
The solution set must not contain duplicate quadruplets.
    For example, given array S = {1 0 -1 0 -2 2}, and target = 0.

    A solution set is:
    (-1,  0, 0, 1)
    (-2, -1, 1, 2)
    (-2,  0, 0, 2)

从数列中找出所有四元组，使这四个数之和为给定的值

参考：
https://github.com/lygithub/leetcode/blob/master/3Sum.cs

*/


public class Solution 
{
    public IList<IList<int>> FourSum(int[] nums, int target) 
    {
        IList<IList<int>> ret = new List<IList<int>>();
        if (nums == null || nums.Length < 4)
        {
            return ret;
        }

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            for (int j = i + 1; j < nums.Length - 2; j++)
            {

                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    continue;
                }

                int k = j + 1;
                int l = nums.Length - 1;

                while (k < l)
                {
                    if (k > j + 1 && nums[k] == nums[k - 1])
                    {
                        k++;
                        continue;
                    }

                    int sum = nums[i] + nums[j] + nums[k] + nums[l];

                    if (sum - target == 0)
                    {
                        IList<int> list = new List<int>();

                        list.Add(nums[i]);
                        list.Add(nums[j]);
                        list.Add(nums[k]);
                        list.Add(nums[l]);

                        ret.Add(list);

                    }

                    int x = (sum - target > 0) ? l-- : k++;
                }
            }
        }
        return ret;
    }
}
