using System;
using System.Collections.Generic;

namespace LeetCode.Easy.Undefined;

public class HappyNumber
{
    // интересное решение условием выхода в виде гонки
    // когда первое число вычисляется a = square(n)
    // второе b = square(square(n))
    public bool IsHappy(int n)
    {
        if (n == 1)
            return true;

        var set = new HashSet<int>();
        while (n != 1 && !set.Contains(n))
        {
            set.Add(n);
            n = Square(n);
            if (n == 1)
                return true;
        }

        return false;

        int Square(int n)
        {
            var sum = 0;
            while (n != 0)
            {
                sum += (int)Math.Pow(n % 10, 2);
                n /= 10;
            }

            return sum;
        }
    }


    public void Test()
    {
        Console.WriteLine(IsHappy(19));
    }
}