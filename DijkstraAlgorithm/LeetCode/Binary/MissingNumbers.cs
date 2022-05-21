using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
     
    Given an array nums containing n distinct numbers in the range [0, n], 
    return the only number in the range that is missing from the array.

 

    Example 1:

    Input: nums = [3,0,1]
    Output: 2
    Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 
    2 is the missing number in the range since it does not appear in nums.

     */

    public class MissingNumbers
    {
        public int MissingNumberMethod(int[] nums)
        {
            return nums.Length * (nums.Length + 1) / 2 - nums.Sum();
        }
    }
}
