using System;
using System.Collections.Generic;

namespace LeetCode.Medium;

public class InsertInterval
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
            return new[] {newInterval};

        var result = new List<int[]>(intervals.Length);
        var start = newInterval[0];
        var end = newInterval[1];
        bool added = true;
        for (int i = 0; i < intervals.Length; i++)
        {
            if (intervals[i][1] < start)
            {
                result.Add(intervals[i]);
                continue;
            }

            if (intervals[i][0] <= start && intervals[i][1] >= start || intervals[i][0]<=end && intervals[i][1]>=end)
            {
                start = Math.Min(intervals[i][0], start);
                end = Math.Max(intervals[i][1], end);
            }


            if (intervals[i][0] > newInterval[1])
            {
                if (added || start == 0 && end == 0)
                {
                    result.Add(new []{start,end});
                    added = false;
                }
                result.Add(intervals[i]);
            }
        }
        if (added)
        {
            result.Add(new []{start,end});
        }
        
        return result.ToArray();
    }

    public void Test()
    {
        // var ans = Insert(new []{ new int[] {1,3},new []{6,9}}, new []{2,5});
        // var ans = Insert(new []{ new int[] {1,5}}, new []{0,0});
        // var ans = Insert(new []{ new []{1,2},new []{3,5},new []{6,7},new []{8,10},new []{12,16}}, new []{4,8});
        var ans = Insert(new []{ new []{1,5}}, new []{2,3});
        // write ans to console 
        foreach (var a in ans)
        {
            Console.Write($"[{a[0]}, {a[1]}] ");
        }
        
    }
}