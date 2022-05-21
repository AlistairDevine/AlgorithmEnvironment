using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.

    Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.

    The test cases are generated so that the answer will be less than or equal to 2 * 109.

    Example 2:

    Input: m = 3, n = 2
    Output: 3
    Explanation: From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
    1. Right -> Down -> Down
    2. Down -> Down -> Right
    3. Down -> Right -> Down
     
     */

    public class UniquePath
    {
        public int UniquePaths(int m, int n)
        {
            int[,] matrix = new int[m, n];

            matrix[0, 0] = 1;

            if (m > 1)
                for (int i = 1; i <= matrix.GetLength(0) - 1; i++)
                    matrix[i, 0] = 1;

            if (n > 1)
                for (int i = 1; i <= matrix.GetLength(1) - 1; i++)
                    matrix[0, i] = 1;

            for (int i = 1; i <= matrix.GetLength(0) - 1; i++)
                for (int j = 1; j <= matrix.GetLength(1) - 1; j++)
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];

            return matrix[m - 1, n - 1];
        }
    }
}
