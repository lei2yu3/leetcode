/*

Given an integer, convert it to a roman numeral.

Input is guaranteed to be within the range from 1 to 3999.

字符串转换

wiki of roman numeral:
http://zh.wikipedia.org/zh/%E7%BD%97%E9%A9%AC%E6%95%B0%E5%AD%97

阿拉伯数字转化为罗马数字
分别对个十百千位进行转换。

亦可分为：
int A[] = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
String R[] = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
若num大于某个值A，则取其对应罗马数字R然后num减A，直到num等于1。

*/


public class Solution {
    public String intToRoman(int num) {
        String M[] = {"", "M", "MM", "MMM"};
        String C[] = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
        String X[] = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
        String I[] = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
        return M[num/1000] + C[(num%1000)/100] + X[(num%100)/10] + I[num%10];
    }
}
