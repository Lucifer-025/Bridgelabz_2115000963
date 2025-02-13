using System;
using System.Collections.Generic;

public class LongestConsecutiveSequence
{
    public static int FindLongestSequence(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in nums)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num, count = 1;
                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    count++;
                }
                longest = Math.Max(longest, count);
            }
        }
        return longest;
    }
}
