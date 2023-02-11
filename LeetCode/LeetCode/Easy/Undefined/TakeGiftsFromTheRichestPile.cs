using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy.Undefined;

// You are given an integer array gifts denoting the number of gifts in various piles. Every second, you do the following:
//
// Choose the pile with the maximum number of gifts.
//     If there is more than one pile with the maximum number of gifts, choose any.
//     Leave behind the floor of the square root of the number of gifts in the pile. Take the rest of the gifts.
//     Return the number of gifts remaining after k seconds.
public class TakeGiftsFromTheRichestPile
{
    public long PickGifts(int[] gifts, int k)
    {
        for (int i = gifts.Length-1; i >= gifts.Length-k; i--)
        {
            var val = gifts.Max();
            var j = indexOf(gifts,val);
            val = (int)Math.Floor(Math.Sqrt(val));
            gifts[j] = val;
        }
        
        return gifts.Sum(d=>(long)d);

        int indexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }

            return -1;
        }
    }

    public void Test()
    {
        Console.WriteLine(PickGifts(new int[] { 25,64,9,4,100 }, 4));
    }
}