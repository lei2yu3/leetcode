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
