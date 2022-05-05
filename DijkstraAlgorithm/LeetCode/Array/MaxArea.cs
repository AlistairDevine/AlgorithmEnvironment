using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*

    Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

    Notice that the solution set must not contain duplicate triplets.


    Example 1:

    Input: nums = [-1,0,1,2,-1,-4]
    Output: [[-1,-1,2],[-1,0,1]]

     */

    public class MaxArea
    {
        public int MaxAreaMethod(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }

            int maxArea = 0;
            int i = 0;
            int j = height.Length - 1;

            while (i < j)
            {
                int w = j - 1;
                int h = Math.Min(height[i], height[j]);
                maxArea = Math.Max(maxArea, w * h);

                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return maxArea;
        }
    }
}
