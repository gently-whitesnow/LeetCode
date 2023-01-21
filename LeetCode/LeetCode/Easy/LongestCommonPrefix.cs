using System;
using System.Collections.Generic;

namespace LeetCode.Easy;

public class LongestCommonPrefix
{
    // Input: strs = ["fowerdf","fowdf","dightdf"]
    // Output: "fl"
    string Solve(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        var buffer = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            if (string.IsNullOrEmpty(buffer))
                return "";
            buffer = CheckContains(strs[i], buffer);
        }

        return buffer;
        
        string CheckContains(string target, string buffer)
        {
            if (string.IsNullOrEmpty(buffer))
                return "";
            if(target.StartsWith(buffer))
                return buffer;
            return CheckContains(target, buffer.Substring(0, buffer.Length-1));
            // var right = "";
            // if(buffer.Length>1)
            //     right = CheckContains(target, buffer.Substring(1, buffer.Length-2));
            //
            // if (left.Length > right.Length)
            //     return left;
            // return right;
        }
    }

    

    public void Test()
    {
        // test
        var strs = new string[] { "reflower","flow","flight" };
        var result = Solve(strs);
        Console.WriteLine(result);
    }
}