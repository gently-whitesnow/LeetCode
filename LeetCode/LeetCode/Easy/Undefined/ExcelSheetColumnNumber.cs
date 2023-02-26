using System;

namespace LeetCode.Easy.Undefined;

public class ExcelSheetColumnNumber
{
    public int TitleToNumber(string columnTitle)
    {
        var counter = columnTitle.Length-1;
        var sum = 0;
        foreach (var sign in columnTitle)
        {
            sum += (int)Math.Pow(26,counter)*(sign - '@');
            counter--;
        }

        return sum;
    }

    public void Test()
    {
        Console.WriteLine(TitleToNumber("AA"));
    }
}