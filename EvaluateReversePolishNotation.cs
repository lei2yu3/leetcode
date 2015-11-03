/*

Evaluate the value of an arithmetic expression in Reverse Polish Notation.

Valid operators are +, -, *, /. Each operand may be an integer or another expression.

Some examples:
  ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
  ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6
  
逆波兰表达式  
  
参考：
https://en.wikipedia.org/wiki/Reverse_Polish_notation

*/


public class Solution 
{
    public int EvalRPN(string[] tokens) 
    {
        if (tokens.Length < 1)
            return 0;
        if (tokens.Length == 1)
            return Convert.ToInt16(tokens[0]);

        Stack<int> s = new Stack<int>();
        int a = 0;
        int b = 0;

        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i].Equals("+"))
            {
                b = s.Pop();
                a = s.Pop();
                s.Push(a + b);
            }
            else if (tokens[i].Equals("-"))
            {
                b = s.Pop();
                a = s.Pop();
                s.Push(a - b);
            }
            else if (tokens[i].Equals("*"))
            {
                b = s.Pop();
                a = s.Pop();
                s.Push(a * b);
            }
            else if (tokens[i].Equals("/"))
            {
                b = s.Pop();
                a = s.Pop();
                s.Push(a / b);
            }
            else
            {
                s.Push(Convert.ToInt16(tokens[i]));
            }
        }

        return s.Peek();
    }
}
