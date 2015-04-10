public class Solution {
    public void Rotate(int[,] matrix) {
        
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
