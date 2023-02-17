using System;
using System.Collections.Generic;

namespace LeetCode.Easy.Arrays;

public class PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        var rowsList = new List<IList<int>>(numRows);
        rowsList.Add(new List<int>{1});
        var counter = 2;
        for (int i = 1; i < numRows; i++)
        {
            rowsList.Add(new List<int>());
            for (int j = 0; j < counter; j++)
            {
                var slow = j-1>=0?rowsList[i-1][j-1]:0;
                var fast = j<rowsList[i - 1].Count?rowsList[i - 1][j]:0;
                rowsList[i].Add(slow+fast);
            }
            counter++;
        }
        return rowsList;
    }

    public void Test()
    {
        var ans = Generate(5);
        foreach (var list in ans)
        {
            foreach (var l in list)
            {
                Console.Write(l);
            }
            Console.WriteLine();
        }
    }
    
}