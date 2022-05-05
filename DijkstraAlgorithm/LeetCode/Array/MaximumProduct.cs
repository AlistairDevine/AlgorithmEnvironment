using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*

    Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.

    The test cases are generated so that the answer will fit in a 32-bit integer.

    A subarray is a contiguous subsequence of the array.

    Example 1:

    Input: nums = [2,3,-2,4]
    Output: 6
    Explanation: [2,3] has the largest product 6.

    */
    public class MaximumProduct
    {
        public int MaxProduct(int[] nums)
        {
            //check for nullable reference 
            int sum = 0;
            int maxSum = nums[0];

            //scan through the nums[] array, for loop
            //temp sum to times against the next iteration of the loop
            for (int i = 0; i < nums.Length; i++)
            {
                sum *= nums[i];
                if (nums[i] > sum)
                {
                    sum = nums[i];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            //return sum output
            return maxSum;
        }
    }
}
