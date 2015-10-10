/*

Suppose a sorted array is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

You are given a target value to search. If found in the array return its index, otherwise return -1.

You may assume no duplicate exists in the array.

旋转有序数列二分查找

*/


public class Solution {
    public int search(int[] A, int target) {
        
        int left = 0;
        int right = A.length - 1;
 
        while (left <= right) {
            int mid = left + ((right - left) >> 1);
 
            if (A[mid] == target)
                return mid;
                
            if (A[mid] >= A[left]) { // left half array sorted
                if (target < A[mid] && target >= A[left]) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            } else { // right half array sorted
                if (target > A[mid] && target <= A[right]) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
        }
 
        return -1;
    }
}
