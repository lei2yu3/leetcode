/*

The count-and-say sequence is the sequence of integers beginning as follows:
1, 11, 21, 1211, 111221, ...

1 is read off as "one 1" or 11.
11 is read off as "two 1s" or 21.
21 is read off as "one 2, then one 1" or 1211.
Given an integer n, generate the nth sequence.

Note: The sequence of integers will be represented as a string.

字符串的读取
特殊处理首位字符和超出输入字符长度时

C++整型转换string时，需#include "sstream"
stringstream ss;
ss << count;
ret += ss.str();
ss.clear();

*/


public class Solution 
{
    public string getNext(string n)
    {
        int count = 0;  // 计数器
        char value = '\0';  // say
        string ret = String.Empty;
        
        for (int i = 0; i < n.Length; i++)
        {   
            // 字符首位
            if (i == 0)
            {
                value = n[i];
                count = 1;
                continue;
            }
            
            // 相等时计数器加一，不等时修改输出字符串，然后重新设置count和value
            if (n[i] == value)
            {
                count++;
            }
            else
            {
                // when cast int to string in C++, #include “sstream”
                // stringstream ss;
                // ss << count;
                // ret += ss.str();
                // ss.clear();
                ret += count; // C++
                ret += value;
                
                value = n[i];
                count = 1;
            }
        }
        
        // 超出字符串长度时
        if (count > 0 && value > 0)
        {
            ret += count; // C++
            ret += value;
        }

        return ret;
    }

    public string CountAndSay(int n)
    {
        if (n < 1) return "";
        if (n == 1) return "1";

        string s = "1";

        for (int i = 1; i < n; i++)
        {
            s = getNext(s);
        }

        return s;
    }
}
