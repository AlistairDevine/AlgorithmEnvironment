using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    Given two strings text1 and text2, return the length of their longest common subsequence. If there is no common subsequence, return 0.

    A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.

    For example, "ace" is a subsequence of "abcde".
    A common subsequence of two strings is a subsequence that is common to both strings.

 

    Example 1:

    Input: text1 = "abcde", text2 = "ace" 
    Output: 3  
    Explanation: The longest common subsequence is "ace" and its length is 3.
     
     */

    public class CommonSubsequence
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int r = text1.Length, c = text2.Length;
            var dp = new int[r + 1, c + 1];
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }

            return dp[r, c];
        }
    }
}
