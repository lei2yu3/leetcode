class Solution {
public:
    double pow(double x, int n) {
    
        if (x == 0) return 0.0;
        if (n == 0) return 1;
        
        unsigned int exp = n;
        
        // n is negtive
        if(n < 0){
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
