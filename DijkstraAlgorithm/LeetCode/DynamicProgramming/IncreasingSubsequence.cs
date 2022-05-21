using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    Given an integer array nums, return the length of the longest strictly increasing subsequence.

    A subsequence is a sequence that can be derived from an array by deleting some or no elements without changing the order of the remaining elements. For example, [3,6,2,7] is a subsequence of the array [0,3,1,6,2,2,7].

 

    Example 1:

    Input: nums = [10,9,2,5,3,7,101,18]
    Output: 4
    Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.
     
     */

    public class IncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return 1;
            }

            int currentLength = 1;
            int[] continousLength = new int[nums.Length];

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                continousLength[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        continousLength[i] = Math.Max(continousLength[j] + 1, continousLength[i]);
                    }
                }

                currentLength = Math.Max(continousLength[i], currentLength);
            }

            return currentLength;
        }
    }
}
