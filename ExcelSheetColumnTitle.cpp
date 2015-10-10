/*

Given a positive integer, return its corresponding column title as appear in an Excel sheet.

For example:

1 -> A
2 -> B
3 -> C
...
26 -> Z
27 -> AA
28 -> AB 

10进制转化为26进制。不断做除法求商，不断求余数。
不是从0开始的26进制，所以需要使用n-1。
string.insert() 在指定位置插入字符
string.begin() 获取字符串首位的字符

*/


class Solution {
public:
    string convertToTitle(int n) {
        string s;
        
        while(n > 0)
        {
            s.insert( s.begin(), (n - 1)  % 26 + 'A' );
            n = (n - 1) / 26;
        }
    
        return s;  
    }
};
