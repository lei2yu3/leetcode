/*

Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? 
Find all unique triplets in the array which gives the sum of zero.

Note:
Elements in a triplet (a,b,c) must be in non-descending order. (ie, a ≤ b ≤ c)
The solution set must not contain duplicate triplets.
    For example, given array S = {-1 0 1 2 -1 -4},

    A solution set is:
    (-1, 0, 1)
    (-1, -1, 2)
    
在数列中找出三个数，使得这三个数之和为0

参考：
https://github.com/lygithub/leetcode/blob/master/3SumClosest.cs

*/

public class Solution 
{
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        IList<IList<int>> ll = new List<IList<int>>();
        
        if (nums == null || nums.Length < 3)
        {
            return ll;
        }

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            
            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    j++;
                    continue;
                }

                int sum = nums[i] + nums[j] + nums[k];

                if (sum == 0)
                {
                    IList<int> l = new List<int>();

                    l.Add(nums[i]);
                    l.Add(nums[j]);
                    l.Add(nums[k]);

                    ll.Add(l);
                }

                int x = (sum > 0) ? k-- : j++;
            }
        }

        return ll;
    }
}
