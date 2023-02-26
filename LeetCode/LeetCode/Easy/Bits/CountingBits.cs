using System.Threading.Tasks;

namespace LeetCode.Easy.Bits;

public class CountingBits
{
    public int[] CountBits(int n)
    {
        // по условию нам надо обработать элементы от 0 до n включительно
        n++;
        var resultArray = new int[n];
        Parallel.For(0, n, (i) =>
        {
            resultArray[i] = BitNumbers(i);
        });
        return resultArray;
        
        int BitNumbers(int number)
        {
            int counter = 0;
            for (int i = 0; i < 32; i++)
            {
                int c = number & 1;
                if (c != 0)
                    counter++;
                number >>= 1;
            }

            return counter;
        }
    }

    public void Test()
    {
    }
}