/*

Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.

括号匹配。

遍历字符串，左括号入栈，右括号和栈顶比较是否匹配，若匹配则左括号出栈。若遍历结束后栈不为空则字符串含有未匹配括号。

参考：
完全括号匹配的字符串最内层都是匹配的"()"、"[]"或"{}"，将它们替换为""，于是新的字符串最内层依然是匹配的括号。
重复替换操作，直到字符串中不包含"()"、"[]"或"{}"，若此时字符串不为空则字符串含有未匹配括号。
https://leetcode.com/discuss/65473/short-easy-to-follow-8ms-java-solution
*/


public class Solution 
{
    public bool IsValid(string s) 
    {
        if ((s.Length == 0) || (s.Length % 2 == 1))
            return false;

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Equals('(') || s[i].Equals('{') || s[i].Equals('['))
            {
                stack.Push(s[i]);
            }
            else if (s[i].Equals(')'))
            {
                if (stack.Count == 0 || !stack.Peek().Equals('('))
                    return false;
                else
                    stack.Pop();
            }
            else if (s[i].Equals('}'))
            {
                if (stack.Count == 0 || !stack.Peek().Equals('{'))
                    return false;
                else
                    stack.Pop();
            }
            else if (s[i].Equals(']'))
            {
                if (stack.Count == 0 || !stack.Peek().Equals('['))
                    return false;
                else
                    stack.Pop();
            }
        }

        if (stack.Count != 0)
        {
            return false;
        }

        return true;
    }
}


public class AnotherSolution 
{
    public bool IsValid(string s) 
    {
        if ((s.Length == 0) || (s.Length % 2 == 1))
            return false;

        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");

        return s.Length == 0 ? true : false;
    }
}
