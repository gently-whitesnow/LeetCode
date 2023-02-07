using System;
using System.Threading;

namespace LeetCode.Concurency;

public class Foo
{
    private int sinhronizedValue = 0;
    SpinWait spin = new SpinWait();
    
    public Foo() {
        
    }

    public void First(Action printFirst) {
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        Interlocked.Increment(ref sinhronizedValue);
    }

    public void Second(Action printSecond)
    {
        // SpinWait.SpinUntil(()=>sinhronizedValue==1);
        while (sinhronizedValue!=1)
        {
            spin.SpinOnce();
        }
        printSecond();
        Interlocked.Increment(ref sinhronizedValue);
    }

    public void Third(Action printThird)
    {
        // SpinWait.SpinUntil(()=>sinhronizedValue==2);
        while (sinhronizedValue!=2)
        {
            spin.SpinOnce();
        }
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}