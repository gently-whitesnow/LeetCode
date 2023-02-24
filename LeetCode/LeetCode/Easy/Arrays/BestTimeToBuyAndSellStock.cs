namespace LeetCode.Easy.Arrays;

public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        var min = int.MaxValue;
        var diff = 0;

        foreach (var p in prices)
        {
            if (p < min)
                min = p;
            if (p - min > diff)
            {
                diff = p - min;
            }
        }

        return diff;
    }

    public void Test()
    {
    }
}