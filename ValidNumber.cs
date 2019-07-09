/*
Validate if a given string can be interpreted as a decimal number.

Some examples:
"0" => true
" 0.1 " => true
"abc" => false
"1 a" => false
"2e10" => true
" -90e3   " => true
" 1e" => false
"e3" => false
" 6e-1" => true
" 99e2.5 " => false
"53.5e93" => true
" --6 " => false
"-+3" => false
"95a54e53" => false

Valid characters:
Numbers 0-9
Exponent - "e"
Positive/negative sign - "+"/"-"
Decimal point - "."
*/

public class Solution 
{
    public bool IsNumber(string s) 
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)) return false;

        int state = 0;
        for (int i = 0; i < s.Length; i++)
        {
            state = DFAGraph[state, GetCharType(s[i])];
            if (state == -1) return false;
        }

        return FinalStates[state];
    }
    
    public static int GetCharType(char inputChar)
    {
        switch (inputChar)
        {
            case ' ':
                return 0;
            case '+':
            case '-':
                return 1;
            case char c when c >= '0' && c <= '9':
                return 2;
            case '.':
                return 3;
            case 'E':
            case 'e':
                return 4;
            default:
                return 5;
        }
    }
    
    private static readonly int[,] DFAGraph =
    {
        { 0, 1, 6, 2, -1, -1, }, 
        { -1, -1, 6, 2, -1, -1, }, 
        { -1, -1, 3, -1, -1, -1, }, 
        { 8, -1, 3, -1, 4, -1, }, 
        { -1, 7, 5, -1, -1, -1, }, 
        { 8, -1, 5, -1, -1, -1, }, 
        { 8, -1, 6, 3, 4, -1, }, 
        { -1, -1, 5, -1, -1, -1, }, 
        { 8, -1, -1, -1, -1, -1, }, 
    };
        
    private static readonly bool[] FinalStates = { false, false, false, true, false, true, true, false, true };
}
