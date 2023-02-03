using System;

namespace LeetCode.Easy;

public class AddBinary
{
    string Solve(string a, string b)
    {
        if (a.Length > b.Length)
            b = b.PadLeft(a.Length, '0');
        else if (a.Length < b.Length)
            a = a.PadLeft(b.Length, '0');

        var str = "";
        int overflow = 0;
        for (int iterator = a.Length - 1; iterator >= 0; iterator--)
        {
            Evaluate(a[iterator], b[iterator], ref str, ref overflow);
        }

        if (overflow == 1)
            str = "1" + str;
        return str;

        void Evaluate(char? first, char? second, ref string str, ref int overflow)
        {
            switch (ParseInt(first) + ParseInt(second) + overflow)
            {
                case 3:
                {
                    str = "1" + str;
                    break;
                }
                case 2:
                {
                    str = "0" + str;
                    overflow = 1;
                    break;
                }
                case 1:
                {
                    str = "1" + str;
                    if (overflow == 1)
                        overflow = 0;
                    break;
                }
                case 0:
                {
                    str = "0" + str;
                    break;
                }
            }
        }

        int ParseInt(char? symbol)
        {
            if (symbol.HasValue && int.TryParse(symbol.Value.ToString(), out var val) && val == 1)
                return 1;
            return 0;
        }
    }


    public void Test()
    {
        Console.Write(Solve("11", "1"));
    }
}