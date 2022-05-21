﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    Reverse bits of a given 32 bits unsigned integer.

    Note:

    Note that in some languages, such as Java, there is no unsigned integer type. 
    In this case, both input and output will be given as a signed integer type. 
    They should not affect your implementation, as the integer's internal binary representation is the same, 
    whether it is signed or unsigned.
    In Java, the compiler represents the signed integers using 2's complement notation. 
    Therefore, in Example 2 above, the input represents the signed integer -3 and the output represents the signed integer -1073741825.
 

    Example 1:

    Input: n = 00000010100101000001111010011100
    Output:    964176192 (00111001011110000010100101000000)
    Explanation: The input binary string 00000010100101000001111010011100 represents the unsigned integer 43261596, 
    so return 964176192 which its binary representation is 00111001011110000010100101000000.

     */

    public class ReverseBits
    {
        public uint reverseBitsMethod(uint n)
        {
            uint res = 0;
            for (int i = 31; i >= 0; i--)
            {
                uint bit = (n >> i) & 1;
                res = res | (bit << (31 - i));
            }
            return res;
        }
    }
}
