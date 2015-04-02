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
