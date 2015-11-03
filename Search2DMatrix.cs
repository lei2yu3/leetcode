/*

Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

Integers in each row are sorted from left to right.
The first integer of each row is greater than the last integer of the previous row.
For example,

Consider the following matrix:

[
  [1,   3,  5,  7],
  [10, 11, 16, 20],
  [23, 30, 34, 50]
]
Given target = 3, return true.

查找二维数组，数组每行左边的数小于右边的数，数组每行第一个数大于前一行所有的数

先对第一列进行查找，定位到比target大的数的前一行
再对这一行进行查找

把这个二维数组当作是一维的有序数列进行二分查找
n * m matrix convert to an array => matrix[x][y] => a[x * m + y]
an array convert to n * m matrix => a[x] =>matrix[x / m][x % m];

https://leetcode.com/discuss/10735/dont-treat-it-as-a-2d-matrix-just-treat-it-as-a-sorted-list

*/


public class Solution 
{
    public bool SearchMatrix(int[,] matrix, int target) 
    {
        if (matrix == null || matrix.Length < 1)
        {
            return false;
        }

        int row = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (target == matrix[i, 0])
            {
                return true;
            }
            else if (target > matrix[i, 0])
            {
                row = i;
            }
        }

        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (target == matrix[row, j])
            {
                return true;
            }
        }

        return false;
    }
}
