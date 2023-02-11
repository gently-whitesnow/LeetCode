using System;
using System.Collections.Generic;

namespace LeetCode.Easy.Strings;

public class ValidParentheses
{
    bool Solve(string s)
    {
        if (s.Length < 1 || s.Length%2!=0)
            return false;
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if(c=='('||c=='{'||c=='[')
                stack.Push(c);
            else
            {
                if (stack.Count == 0)
                    return false;
                var closures = stack.Pop();
                if (closures == '(' && c != ')')
                    return false;
                if (closures == '{' && c != '}')
                    return false;
                if (closures == '[' && c != ']')
                    return false;
            }
        }

        return stack.Count == 0;
    }
    
    public void Test()
    {
        Console.WriteLine(Solve("()"));
        Console.WriteLine(Solve("()[]{}"));
        Console.WriteLine(Solve("(]"));
        Console.WriteLine(Solve("([)]"));
        Console.WriteLine(Solve("{[]}"));
        // "{([)]}"
    }

    public bool InterestingSolution(string s)
    {
        while (s.Contains("()")||s.Contains("[]")||s.Contains("{}"))
        {
            s = s.Replace("()", "").Replace("[]", "")
                .Replace("{}", "");
        }

        return s.Length == 0;
    }
}