using System;
using System.Collections.Generic;

namespace LeetCode.Easy.Arrays;

public class PascalsTriangle2_0
{
    public IList<int> GetRow(int rowIndex)
    {
        var resultList = new List<int>(rowIndex + 1);

        var numberOfCalculations = 0;
        for (int i = 0; i <= rowIndex; i++)
        {
            var fastIndex = 1;
            var slowValue = 1;
            for (int j = 1; j < numberOfCalculations; j++)
            {
                var nextValue = slowValue + resultList[fastIndex];
                if (nextValue > 1)
                {
                    slowValue = resultList[fastIndex];
                    resultList[fastIndex] = nextValue;
                }
                fastIndex++;
            }
            resultList.Add(1);

            numberOfCalculations++;
        }
        
        return resultList;
    }
    
    public IList<int> GetRowBetter(int rowIndex)
    {
        var resultList = new List<int>(rowIndex + 1);

        resultList.Add(1);
        for (int i = 1; i <= rowIndex; i++)
        {
            for (int j = resultList.Count-1; j > 0; j--)
            {
                resultList[j] += resultList[j-1];
            }
            resultList.Add(1);
        }
        
        return resultList;
    }

    public void Test()
    {
        var ans = GetRow(1);
        foreach (var a in ans)
        {
            Console.Write(a);
        }
    }
}