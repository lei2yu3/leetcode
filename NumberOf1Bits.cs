/*

Write a function that takes an unsigned integer and returns the number of ’1' bits it has (also known as the Hamming weight).

For example, the 32-bit integer ’11' has binary representation 00000000000000000000000000001011, so the function should return 3.

判断二进制数字中有几个1

不断右移，和1进行"与运算"

*/


public class Solution {
    public int HammingWeight(uint n) 
    {
        int ret = 0;
        while (n > 0)
        {
            // n的最右一位是否为1
            if ((n & 1) == 1)
                ret++;
            
            // 右移一位    
            n >>= 1;
        }
        
        // another solution
        //while (n > 0)
        //{
        //    n &= (n - 1);
        //    ret++;
        //}
        
        return ret;
    }
}
