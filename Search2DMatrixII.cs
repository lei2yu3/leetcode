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

*/


public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        if (matrix == null || matrix.Length < 1)
            {
                return false;
            }
            
            int col = matrix.GetLength(1) - 1;
            int row = 0;

            while ((row <= (matrix.GetLength(0) - 1)) && (col >= 0))
            {
                if (target < matrix[row, col])
                    col--;
                else if (target > matrix[row, col])
                    row++;
                else
                    return true;
            }

            return false;
    }
}
