class Solution {
public:
    int searchInsert(int A[], int n, int target) {
        for(int i = 0; i < n; i ++)
        {
            if(target <= A[i])
                return i;
            if(i == n-1)
                return n;
        }
    }
};
