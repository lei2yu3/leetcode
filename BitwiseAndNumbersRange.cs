/*

Given a range [m, n] where 0 <= m <= n <= 2147483647, return the bitwise AND of all numbers in this range, inclusive.

For example, given the range [5, 7], you should return 4.

对连续正整数进行与运算

与运算两个数不同则结果为0，与运算两个数相同则结果不变。n与n+1进行与运算结果将右边至少一位至多两位变成0左边不变。

m到n之间所有正整数的二进制数，保留从最左开始相同的位数，剩下不相同的位数补0
[9, 10, 11] = [1001, 1010, 1011] 保留从最左开始相同的位数为左起第一位10，则结果为1000
[12, 15] = [1100, 1101, 1110, 1111] 保留从最左开始相同的位数为左起前两位11，则结果为1100

*/


public class Solution 
{
    public int RangeBitwiseAnd(int m, int n) 
    {
        int i = 0;
        while (m != n)
        {
            m >>= 1;
            n >>= 1;
            i++;
        }
        
        return n << i;
    }
}
