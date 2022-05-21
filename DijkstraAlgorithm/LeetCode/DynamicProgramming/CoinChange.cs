using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

    Return the fewest number of coins that you need to make up that amount. 
    If that amount of money cannot be made up by any combination of the coins, return -1.

    You may assume that you have an infinite number of each kind of coin.

 

    Example 1:

    Input: coins = [1,2,5], amount = 11
    Output: 3
    Explanation: 11 = 5 + 5 + 1
     
     */

    public class CoinChange
    {
        public int CoinChangeMethod(int[] coins, int amount)
        {
            if (amount < 1)
            {
                return 0;
            }

            System.Array.Sort(coins);
            return helper(coins, amount, new int[amount]);
        }

        private int helper(int[] coins, int amount, int[] dp)
        {
            if (amount == 0)
            {
                return 0;
            }

            if (dp[amount - 1] != 0)
            {
                return dp[amount - 1];
            }

            int min = int.MaxValue;
            foreach (int coin in coins)
            {
                if (amount < coin)
                {
                    break;
                }

                int res = helper(coins, amount - coin, dp);
                if (res >= 0 && res < min)
                {
                    min = 1 + res;
                }
            }

            dp[amount - 1] = (min == int.MaxValue) ? -1 : min;
            return dp[amount - 1];
        }
    }
}
