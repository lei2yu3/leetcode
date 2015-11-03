/*

You are climbing a stair case. It takes n steps to reach to the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

经推导，结果为斐波那契数列

分析过程：
http://blog.csdn.net/wangshihui512/article/details/9672471

*/


class Solution 
{
public:
    int climbStairs(int n) 
    {
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
