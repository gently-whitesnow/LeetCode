using System;

namespace LeetCode.Easy.Undefined;

public class ExcelSheetColumnTitle
{
    public string ConvertToTitle(int columnNumber)
    {
        if (columnNumber <= 26)
        {
            // because after '@' next char 'A'
            var a = (char) ('@' + columnNumber);
            return a.ToString();
        }

        var raw = columnNumber % 26 == 0 
            ? 26 
            : columnNumber % 26;

        return ConvertToTitle((columnNumber - 1) / 26) + (char) ('@' + raw);
    }
    
    public string ConvertToTitleBetter(int columnNumber)
    {
        return columnNumber==0?"":
                ConvertToTitleBetter(--columnNumber/26) + (char)(columnNumber%26+'A');
    }

    public void Test()
    {
        Console.WriteLine("1-" + ConvertToTitle(1));
        Console.WriteLine("2-" + ConvertToTitle(2));
        Console.WriteLine("25-" + ConvertToTitle(25));
        Console.WriteLine("26-" + ConvertToTitle(26));
        Console.WriteLine("27-" + ConvertToTitle(27));
        Console.WriteLine("28-" + ConvertToTitle(28));
        Console.WriteLine("51-" + ConvertToTitle(51));
        Console.WriteLine("52-" + ConvertToTitle(52));
        Console.WriteLine("53-" + ConvertToTitle(53));
    }
}