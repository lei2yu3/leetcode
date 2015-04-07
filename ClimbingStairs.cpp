class Solution {
public:
    int climbStairs(int n) {
        if (n < 2) return n;

        int fib1 = 1;
        int fib2 = 1;
        int fib3 = 0;
        for (int i = 2; i <= n; i++ ) 
        {
            fib3 = fib1 + fib2;
            fib1 = fib2;
            fib2 = fib3;
        }

        return fib3;
    }
};
