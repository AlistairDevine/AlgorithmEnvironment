using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /*
     
    Given a string s and a dictionary of strings wordDict, return true if s can be segmented into a space-separated sequence of one or more dictionary words.

    Note that the same word in the dictionary may be reused multiple times in the segmentation.

 

    Example 1:

    Input: s = "leetcode", wordDict = ["leet","code"]
    Output: true
    Explanation: Return true because "leetcode" can be segmented as "leet code". 

     */

    public class WorldBreak
    {
        public bool WordBreakMethod(string s, IList<string> wordDict)
        {
            var n = s.Length;
            var dp = new bool[n + 1];

            dp[0] = true;
            for (int i = 1; i <= n; i++)
            {
                var sIndex = i - 1;
                foreach (var word in wordDict)
                {
                    var wordLen = word.Length;
                    var lastChar = word.Last();

                    if (lastChar == s[sIndex] && sIndex + 1 >= wordLen)
                    {
                        if (s.Substring(sIndex - wordLen + 1, wordLen) == word)
                        {
                            dp[i] |= dp[i - wordLen];
                        }
                    }
                }
            }

            return dp[n];
        }
    }
}
