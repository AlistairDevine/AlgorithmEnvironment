using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{

    /*

    Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.


    Example 1:

    Input: nums = [1,2,3,1]
    Output: true

     */
    public class ContainsDuplicate
    {
        public bool ContainsDuplicateMethod(int[] nums)
        {
            Hashtable hash = new Hashtable();

            foreach (var item in nums)
            {
                if (hash.Contains(item))
                {
                    return true;
                }
                else
                {
                    hash.Add(item, null);
                }
            }
            return false;
        }
    }
}
