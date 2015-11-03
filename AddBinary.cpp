/*

Given two binary strings, return their sum (also a binary string).

For example,
a = "11"
b = "1"
Return "100".

二进制相加求和
需要注意位数和进位

*/


class Solution 
{
public:
    string addBinary(string a, string b) 
    {
        int sizeA = a.length();
        int sizeB = b.length();
        int sizeSum = sizeA >= sizeB ? sizeA + 1 : sizeB + 1;
        string stringSum(sizeSum, '0'); // 和的位数，要么等于较长加数位数，要么比较长加数位数多一位
        
        // 给两个加数左边添零，使其位数与和的位数相等
        a = string(sizeSum - sizeA, '0') + a;
        b = string(sizeSum - sizeB, '0') + b;
        
        // 从右向左依次按位相加，大于1则进位
        for(int i = sizeSum - 1; i >= 0; i--)
        {
           int carry = (stringSum[i] - '0') + (a[i] - '0') + (b[i] - '0');
           stringSum[i] = '0' + carry % 2;
           stringSum[i - 1] = '0' + (stringSum[i - 1] - '0' + carry / 2);
        }
        
        // 若无进位，去掉首位的0
        if(stringSum[0] == '0')
            return &stringSum[1];
        
        return stringSum;
    }
};
