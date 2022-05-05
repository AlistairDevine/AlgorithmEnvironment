using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchRotated
    {
        /*

        There is an integer array nums sorted in ascending order (with distinct values).

        Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].

        Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

        You must write an algorithm with O(log n) runtime complexity.


        Example 1:

        Input: nums = [4,5,6,7,0,1,2], target = 0
        Output: 4

         */
        public int Search(int[] nums, int target)
        {
            if (nums is null || nums.Length is 0)
            {
                return -1;
            }
            var offset = FindMinIndex(nums);
            return BinarySearch(nums, target, offset);
        }

        private int FindMinIndex(int[] nums)
        {
            int n = nums.Length;
            int start = 0;
            int end = n - 1;

            while (start < end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] > nums[end]) start = mid + 1;
                else end = mid;
            }

            return start;
        }

        private int BinarySearch(int[] nums, int target, int offset)
        {
            int n = nums.Length;
            int start = 0;
            int end = n - 1;

            while (start < end)
            {
                int mid = start + (end - start) / 2;
                int realMid = (mid + offset) % n;

                if (nums[realMid] < target) start = mid + 1;
                else end = mid;
            }

            int index = (start + offset) % n;
            return nums[index] == target ? index : -1;
        }
    }
}
