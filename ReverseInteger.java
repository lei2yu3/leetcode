/*

Reverse digits of an integer.

Example1: x = 123, return 321
Example2: x = -123, return -321


Have you thought about this?
Here are some good questions to ask before coding. Bonus points for you if you have already thought through this!

If the integer's last digit is 0, what should the output be? ie, cases such as 10, 100.

Did you notice that the reversed integer might overflow? Assume the input is a 32-bit integer, then the reverse of 1000000003 overflows. How should you handle such cases?

For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.


整型数字逆序

将Integer转换为String，再转换为CharArray，然后再逆向连接为String，最后转换回Integer。
String.valueOf(x);
s.toCharArray();
Integer.parseInt(ss)

*/


public class Solution {
    public int reverse(int x) {
                if (x >= -9 && x <= 9)
            return x;

        if (x > Integer.MAX_VALUE || x < Integer.MIN_VALUE) {
            throw new NumberFormatException();
        }

        boolean flag = false;

        if (x < 0) {
            x = -x;
            flag = true;
        }

        String s = String.valueOf(x);
        char[] c = s.toCharArray();

        String ss = "";
        for (int i = c.length - 1; i >= 0; i--) {
            ss += c[i];
        }

        return flag == false ? Integer.parseInt(ss) : Integer.parseInt(ss) * -1;
    }
}
