using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    You are a professional robber planning to rob houses along a street. 
    Each house has a certain amount of money stashed, 
    the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected 
    and it will automatically contact the police if two adjacent houses were broken into on the same night.

    Given an integer array nums representing the amount of money of each house, 
    return the maximum amount of money you can rob tonight without alerting the police.

 

    Example 1:

    Input: nums = [1,2,3,1]
    Output: 4
    Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
    Total amount you can rob = 1 + 3 = 4.
     
     */

    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int firstPrevious = 0;
            int secondPrevious = 0;
            int current = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                secondPrevious = firstPrevious;
                firstPrevious = current;
                current = Math.Max(firstPrevious, secondPrevious + nums[i]);
            }

            return current;
        }
    }
}
