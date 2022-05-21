using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    You are climbing a staircase. It takes n steps to reach the top.

    Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

 

    Example 1:

    Input: n = 2
    Output: 2
    Explanation: There are two ways to climb to the top.
    1. 1 step + 1 step
    2. 2 steps 

     */

    public class ClimbingStairs
    {
        public int ClimbingStairsMethod(int n)
        {
            if (n < 3)
            {
                return n;
            }

            int n2 = 2;
            int n1 = 1;
            int res = 0;

            int i = 3;

            while (i++ <= n)
            {
                res = n2 + n1;
                n1 = n2;
                n2 = res;
            }

            return res;
        }
    }
}
