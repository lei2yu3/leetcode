/*

Given an input string, reverse the string word by word.

For example,
Given s = "the sky is blue",
return "blue is sky the".

For C programmers: Try to solve it in-place in O(1) space.

Clarification:
What constitutes a word?
A sequence of non-space characters constitutes a word.
Could the input string contain leading or trailing spaces?
Yes. However, your reversed string should not contain leading or trailing spaces.
How about multiple spaces between two words?
Reduce them to a single space in the reversed string.

使用Split方法将字符串拆分，去掉其中的""空字符串，将数组翻转，对使用空格将数组拼接

参考：
https://leetcode.com/discuss/40615/please-help-c%23-strange-wa-on-a-b

*/


public class Solution 
{
    public string ReverseWords(string s)
    {
        var sc = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();
        Array.Reverse(sc);
        return string.Join(" ", sc).Trim();
        
        //if (s == null || s.Length == 0)
        //    return "";

        //if (s.Trim().Length == 0)
        //    return "";

        //string[] sArray = s.Split(new char[] { ' ' });

        //StringBuilder sb = new StringBuilder();
        //sb.Append(sArray[sArray.Length - 1]);

        //for (int i = s.Length - 1, j = sArray.Length - 2; i >= 0; i--)
        //{
        //    if (s[i].Equals(' '))
        //    {
        //        sb.Append(" ");
        //        sb.Append(sArray[j].ToString());
        //        j--;
        //    }
        //}
        //return sb.ToString();
    }
}
