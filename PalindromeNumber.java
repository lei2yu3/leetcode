/*

Determine whether an integer is a palindrome. Do this without extra space.

Some hints:
Could negative integers be palindromes? (ie, -1)

If you are thinking of converting the integer to string, note the restriction of using extra space.

You could also try reversing an integer. However, if you have solved the problem "Reverse Integer", you know that the reversed integer might overflow. How would you handle such case?

There is a more generic way of solving this problem.

将Integer转换为String
分别从头向后和从尾向前比较每一位的字符是否相同
s.charAt(i)

*/


public class Solution {
    public boolean isPalindrome(int x) {
        if (x < 0)
            return false;

        if (x % 10 < 0)
            return true;

        String s = String.valueOf(x);
        int i = 0;
        int j = s.length() - 1;
        
        for (; i < j; i++, j--) {
            if (s.charAt(i) != s.charAt(j))
                return false;
        }

        return true;
    }
}
