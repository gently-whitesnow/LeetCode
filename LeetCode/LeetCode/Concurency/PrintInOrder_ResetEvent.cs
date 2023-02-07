using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.Concurency;

public class FooV3
{
    AutoResetEvent _second = new (false);
    AutoResetEvent _third = new (false);
    
    public FooV3()
    {
    }

    public void First(Action printFirst) {
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        _second.Set();
    }

    public void Second(Action printSecond)
    {
        _second.WaitOne();
        printSecond();
        _third.Set();
    }

    public void Third(Action printThird)
    {
        _third.WaitOne();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}