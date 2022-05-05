using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*

    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    You can return the answer in any order.


    Example 1:

    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

     */

    public class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target)
        {
            if (nums is null && nums?.Length < 2)
            {
                return new int[2];
            }

            Dictionary<int, int> dictionaryInt = new Dictionary<int, int>();

            for (int i = 0; i < nums?.Length; i++)
            {
                if (dictionaryInt.ContainsKey(target - nums[i]))
                {
                    return new int[]{ i,  dictionaryInt[target - nums[i]] };
                }
                else if (!dictionaryInt.ContainsKey(nums[i]))
                {
                    dictionaryInt.Add(nums[i], i);
                }
            }

            return new int[2];

        }
    }
}
