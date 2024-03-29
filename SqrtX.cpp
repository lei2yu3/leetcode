/*

Implement int sqrt(int x).

Compute and return the square root of x.

计算整数的平方根

平方根不大于x / 2 + 1
从1~(x / 2 + 1)，折半查找
如果abs(temp - x / temp) < ACCURACY，则成功，精度ACCURACY可以为任意小数

*/


class Solution 
{
public:
    int sqrt(int x) 
    {
    
        if (x <= 0) return 0;
        if (x < 4) return 1;
    
        int left = 1;
        int right = x / 2 + 1;  // 平方根不会大于x / 2 + 1
        int mid = left + ((right - left) >> 1);
        int temp = 0;
    
        while (left <= right)
        {
            temp = mid;
            if (abs(temp - x / temp) < 0.000000001) // 精度，可以为任意小数
            //if (temp == x / temp) // 不考虑精度
            {
                return mid;
            }
            else
                // 修改mid，若判断temp * temp > x 可能会溢出
                (temp > x / temp) ? (right = mid - 1) : (left = mid + 1);
                
            mid = left + ((right - left) >> 1);
        }
    
        return right;
    }
};
