using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy.Undefined;

public class ClimbingStairs
{
    // Поиском в глубину можно посмотреть закономерность и понять, что это числа фибоначи
    public int SolveDFS(int n)
    {
        var dfs = new Stack<int>();
        dfs.Push(0);
        var c = 0;
        while (dfs.Count != 0)
        {
            var height = dfs.Pop();
            if (height == n)
            {
                c++;
                continue;
            }

            if (height > n)
                continue;

            dfs.Push(height + 1);
            dfs.Push(height + 2);
        }

        return c;
    }

    // поиск n числа фибоначи
    public int Solve(int n)
    {
        var slow = 1;
        var fast = 1;
        return Fibo();

        int Fibo()
        {
            if (n == 1)
                return fast;
            n--;
            (slow, fast) = (fast, fast + slow);
            return Fibo();
        }
    }


    public void Test()
    {
        foreach (var n in Enumerable.Range(1, 5))
        {
            Console.WriteLine(Solve(n));
        }
    }
}