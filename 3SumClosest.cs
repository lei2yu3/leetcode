/*

Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target.
Return the sum of the three integers. You may assume that each input would have exactly one solution.

    For example, given array S = {-1 2 1 -4}, and target = 1.

    The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
    
找出三个整数，使它们的和等于或者最接近于target    

对数组进行排序，
for (i in 1..n-2) 
{
  j = i+1  // Start right after i.
  k = n    // Start at the end of the array.

  while (j < k) 
  {
    // We got a match! All done.
    if (A[i] + A[j] + A[k] == 0) return (A[i], A[j], A[k])

    // We didn't match. Let's try to get a little closer:
    //   If the sum was too big, decrement k.
    //   If the sum was too small, increment j.
    (A[i] + A[j] + A[k] > 0) ? k-- : j++
  }
  // When the while-loop finishes, j and k have passed each other and there's
  // no more useful combinations that we can try with this i.
}

参考：
http://stackoverflow.com/questions/2070359/finding-three-elements-in-an-array-whose-sum-is-closest-to-an-given-number#
https://leetcode.com/discuss/6438/a-n-2-solution-can-we-do-better

*/


public class Solution 
{
    public int ThreeSumClosest(int[] nums, int target) 
    {
        if (nums == null || nums.Length < 3)
        {
            return System.Int16.MaxValue;
        }

        Array.Sort(nums);
        
        int ret = nums[0] + nums[1] + nums[2];

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];

                if (Math.Abs(target - ret) > Math.Abs(target - sum))
                {
                    ret = sum;
                    if (ret == target)
                    {
                        return ret;
                    }
                }

                int x = (sum > target) ? k-- : j++;
            }
        }

        return ret;
    }
}
