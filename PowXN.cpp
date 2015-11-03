/*

Implement pow(x, n).

当n为负数时
当n为MAX_INT(2147483647) or MIN_INT(-2147483648)时

如果n为 奇数，result *= x
如果n为偶数，x = x*x and n = n>>1
这样可以加快n减少的速度

*/


class Solution 
{
public:
    double pow(double x, int n)
    {
    
        if (x == 0) return 0.0;
        if (n == 0) return 1;
        
        unsigned int exp = n;
        
        // n is negtive
        if(n < 0)
        {
            exp = -n;
            x = 1.0 / x;
        }
        
        double ret = 1.0;
        
        // inorder to reduce n more quickly
        while (exp) 
        {
            // n is an odd number, just result *= x;
            if (exp & 1)
            {
                ret *= x;
            }
            
            // n is an even number, x = x*x and n = n>>1
            x *= x;
            exp >>= 1;
        }
    
        return ret;
    }
};
