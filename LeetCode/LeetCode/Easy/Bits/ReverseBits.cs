using System;

namespace LeetCode.Easy.Bits;

// Reverse bits of a given 32 bits unsigned integer.
public class ReverseBits
{
    public uint ReverseIntBits(uint n)
    {
        return Reverser(n, 31);

        uint Reverser(uint currentValue, int index)
        {
            var rest = currentValue % 2;
            var multiple = (uint) Math.Pow(2, index);
            if (currentValue < 2)
                return rest * multiple;

            return rest * multiple+ Reverser(currentValue / 2, index - 1);
        }
    }


    public void Test()
    {
        Console.WriteLine(ReverseIntBits(43261596));
    }
    //964176192
    //482088128
    //2515990144
}