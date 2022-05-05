using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

    The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

    You must write an algorithm that runs in O(n) time and without using the division operation.

    Example 1:

    Input: nums = [1,2,3,4]
    Output: [24,12,8,6]

    */

    public class ProductOfArray
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums is null || nums.Length is 0)
            {
                return null;
            }

            int[] result = new int[nums.Length];

            int temp = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = temp;
                temp *= nums[i];
            }

            temp = 1;

            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] *= temp;
                temp *= nums[i];
            }

            return result;
            //scan through nums 
            //if index == nums[i] then skip that index element
            //for each loop cycle, create a temp to times against
            //output result of temp
        }
    }
}

