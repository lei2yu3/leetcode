/*

Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

Integers in each row are sorted in ascending from left to right.
Integers in each column are sorted in ascending from top to bottom.
For example,

Consider the following matrix:

[
  [1,   4,  7, 11, 15],
  [2,   5,  8, 12, 19],
  [3,   6,  9, 16, 22],
  [10, 13, 14, 17, 24],
  [18, 21, 23, 26, 30]
]
Given target = 5, return true.

Given target = 20, return false.

查找二维数组，数组每行左边的数小于右边的数，数组每列上边的数小于下边的数

设定数组右上角为起始位置A，
如果target<A，则target不会出现在A所在的这一列的下面，因为列有序
如果target>A，则target不会出现在A所在的这一行的左边，因为行有序
这样，每次比较target和数组右上角的数，都可以排除一行或者一列

https://leetcode.com/discuss/48852/my-concise-o-m-n-java-solution

*/


public class Solution 
{
    public bool SearchMatrix(int[,] matrix, int target) 
    {
        if (matrix == null || matrix.Length < 1)
            {
                return false;
            }
            
            // initialize the current position to top right corner
            int col = matrix.GetLength(1) - 1;
            int row = 0;

            while ((row <= (matrix.GetLength(0) - 1)) && (col >= 0))
            {
                if (target < matrix[row, col])  // 目标小于右上，则排除当前列，列减一
                    col--;
                else if (target > matrix[row, col]) // 目标大于右上，则排除当前行，行加一
                    row++;
                else
                    return true;
            }

            return false;
    }
}
