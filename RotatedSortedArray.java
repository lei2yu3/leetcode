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
