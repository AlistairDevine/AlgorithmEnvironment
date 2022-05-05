using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
     Given two integers a and b, return the sum of the two integers without using the operators + and -.

    Example 1:

    Input: a = 1, b = 2
    Output: 3
      
     */

    public class SumTwoIntegers
    {
        public int GetSum(int a, int b)
        {
            while (b is not 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            return a;
        }
    }
}
