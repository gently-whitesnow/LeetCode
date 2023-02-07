using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.Concurency;

public class FooV2
{
    private TaskCompletionSource<bool> completionSource1 = new();
    private TaskCompletionSource<bool> completionSource2 = new();
    
    public FooV2()
    {
    }

    public void First(Action printFirst) {
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        completionSource1.SetResult(true);
    }

    public void Second(Action printSecond)
    {
        completionSource1.Task.Wait();
        printSecond();
        completionSource2.SetResult(true);
    }

    public void Third(Action printThird)
    {
        completionSource2.Task.Wait();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}