using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
     A message containing letters from A-Z can be encoded into numbers using the following mapping:

    'A' -> "1"
    'B' -> "2"
    ...
    'Z' -> "26"
    To decode an encoded message, 
    all the digits must be grouped then mapped back into letters using the reverse of the mapping above (there may be multiple ways). 
    For example, "11106" can be mapped into:

    "AAJF" with the grouping (1 1 10 6)
    "KJF" with the grouping (11 10 6)
    Note that the grouping (1 11 06) is invalid because "06" cannot be mapped into 'F' since "6" is different from "06".

    Given a string s containing only digits, return the number of ways to decode it.

    The test cases are generated so that the answer fits in a 32-bit integer.

 

    Example 1:

    Input: s = "12"
    Output: 2
    Explanation: "12" could be decoded as "AB" (1 2) or "L" (12).
     
     */

    public class DecodeWays
    {
        public int NumDecodings(string s)
        {
            if (s == null || s.Length == 0 || s[0] == '0')
                return 0;

            int n = s.Length;
            int[] dp = new int[n + 1];

            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                int num1 = int.Parse(s.Substring(i - 1, 1));
                int num2 = int.Parse(s.Substring(i - 2, 2));

                int c1 = num1 > 0 ? dp[i - 1] : 0;
                int c2 = num2 >= 10 && num2 <= 26 ? dp[i - 2] : 0;

                dp[i] = c1 + c2;
            }

            return dp[n];
        }
    }
}
