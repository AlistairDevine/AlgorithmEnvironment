using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    You are a professional robber planning to rob houses along a street. 
    Each house has a certain amount of money stashed. All houses at this place are arranged in a circle. 
    That means the first house is the neighbor of the last one. 
    Meanwhile, adjacent houses have a security system connected, 
    and it will automatically contact the police if two adjacent houses were broken into on the same night.

    Given an integer array nums representing the amount of money of each house, 
    return the maximum amount of money you can rob tonight without alerting the police.

 

    Example 1:

    Input: nums = [2,3,2]
    Output: 3
    Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money = 2), 
    because they are adjacent houses.
     
     */

    public class HouseRobberTwo
    {
        public int RobTwo(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];
            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);

            int res1 = RobTwo(nums, 0, nums.Length - 2);
            int res2 = RobTwo(nums, 1, nums.Length - 1);

            return Math.Max(res1, res2);
        }

        private int RobTwo(int[] nums, int start, int end)
        {
            int prevPrev = nums[start];
            int prev = Math.Max(nums[start], nums[start + 1]);

            for (int i = start + 2; i <= end; i++)
            {
                int curr = Math.Max(prevPrev + nums[i], prev);
                prevPrev = prev;
                prev = curr;
            }

            return Math.Max(prevPrev, prev);
        }
    }
}
