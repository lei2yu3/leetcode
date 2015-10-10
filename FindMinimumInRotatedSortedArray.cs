/*

Suppose a sorted array is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

Find the minimum element.

You may assume no duplicate exists in the array.

右旋数组查找最小值

二分查找，比较left，right，mid的大小

*/

public class Solution {
    public int FindMin(int[] num)
    {
        int left = 0;
        int right = num.Length - 1;
        
        // if array is non-rotated
        if (num[left] < num[right])
            return num[left];
        
        //  if array is rotated
        while ((right - left) > 1)
        {
            int mid = left + ((right - left) >> 1);
            
            // 相邻两个数左大右小时，则右边的数为最小值
            if ((num[left] > num[right]) && ((right - left) == 1))
            {
                return num[right];
            }
            else if (num[mid] >= num[left])
            {
                left = mid;
            }
            else if (num[mid] <= num[right])
            {
                right = mid;
            }
        }

        return num[right];
    }
}
