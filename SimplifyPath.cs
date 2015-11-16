/*

Given an absolute path for a file (Unix-style), simplify it.

For example,
path = "/home/", => "/home"
path = "/a/./b/../../c/", => "/c"

Corner Cases:
Did you consider the case where path = "/../"?
In this case, you should return "/".
Another corner case is the path might contain multiple slashes '/' together, such as "/home//foo/".
In this case, you should ignore redundant slashes and return "/home/foo".

以"/"为分隔符将字符串拆分，若是目录则入栈，若是".."则出栈，若是"."则无操作。

*/


public class Solution 
{
    public string SimplifyPath(string path) 
    {
        Stack<string> stack = new Stack<string>();

        foreach (var s in path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries))
        {
            if (s.Equals(".."))
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else if (s.Equals("."))
            {
                continue;
            }
            else
            {
                stack.Push(s);
            }
        }

        StringBuilder sb = new StringBuilder();

        foreach (var s in stack)
        {
            sb.Insert(0, "/" + s);
        }

        return sb.Length == 0 ? "/" : sb.ToString();
    }
}
