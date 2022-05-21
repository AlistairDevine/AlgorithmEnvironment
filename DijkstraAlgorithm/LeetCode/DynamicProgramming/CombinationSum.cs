using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    Given an array of distinct integers nums and a target integer target, 
    return the number of possible combinations that add up to target.

    The test cases are generated so that the answer can fit in a 32-bit integer.

 

    Example 1:

    Input: nums = [1,2,3], target = 4
    Output: 7
    Explanation:
    The possible combination ways are:
    (1, 1, 1, 1)
    (1, 1, 2)
    (1, 2, 1)
    (1, 3)
    (2, 1, 1)
    (2, 2)
    (3, 1)
    Note that different sequences are counted as different combinations. 

     */

    public class CombinationSum
    {
        public int CombinationSum4(int[] nums, int target)
        {
            // dp[i] means number of ways to sum up numbers to i.
            int[] dp = new int[target + 1];

            // only empty array can sum up numbers to 0.
            dp[0] = 1;

            for (int i = 1; i < dp.Length; i++)
            {
                foreach (int num in nums)
                {
                    /*
                        If num is selected at ith step, then the number of ways to sum up 
                        elements to i is dp[i - num]. And each number could be selected.
                    */
                    if (i - num >= 0)
                        dp[i] += dp[i - num];
                }
            }

            return dp[target];
        }
    }
}
