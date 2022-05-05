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

    public class ThreeSum
    {
        public IList<IList<int>> ThreeSumMethod(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (nums is null || nums?.Length < 3)
            {
                return res;
            }

            System.Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0 || (i > 0 && nums[i] == nums[i - 1]))
                {
                    continue;
                }

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    if (nums[i] + nums[left] + nums[right] == 0)
                    {
                        res.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        left++;
                        right--;

                        while (left < right && nums[left] == nums[left - 1])
                        {
                            left++;
                        }
                        while (left < right && nums[right] == nums[right + 1])
                        {
                            right--;
                        }
                    }
                    else if (nums[i] + nums[left] + nums[right] > 0)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            return res;
        }
    }
}
