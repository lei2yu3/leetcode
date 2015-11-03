/*

You are given an n x n 2D matrix representing an image.

Rotate the image by 90 degrees (clockwise).

Follow up:
Could you do this in-place?

二维数组顺时针旋转90度，即(i, j)与(j, m-i)对换
两种办法：
1. 先上下翻转，即(i, j)与(m-i, j)对换；再沿左上到右下的对角线翻转，即(i, j)与(j, i)对换。
2. 先沿右上到左下的对角线翻转，即(i, j)与(n-j, m-i)对换；再上下翻转。

其他解法：
http://www.cnblogs.com/chrischennx/p/4009376.html

*/

public class Solution 
{
    public void Rotate(int[,] matrix) 
    {
        
        int N = matrix.GetLength(0);
        int temp = 0;

        // 上下翻转数组，只对数组的上半部分进行操作，row < (N + 1
        for (int row = 0; row < (N + 1) / 2; row++)
        {
            for (int col = 0; col < N; col++)
            {
                temp = matrix[row, col];
                matrix[row, col] = matrix[N - row - 1, col];
                matrix[N - row - 1, col] = temp;
            }
        }
        
        // 沿左上到右下的对角线翻转，只对数组右上部分进行操作，col >= row
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                if (col >= row)
                {
                    temp = matrix[row, col];
                    matrix[row, col] = matrix[col, row];
                    matrix[col, row] = temp;
                }
            }
        }
    }
}
