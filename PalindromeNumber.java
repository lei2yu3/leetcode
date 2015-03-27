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
