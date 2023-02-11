namespace LeetCode.Easy.Strings;

public class LengthOfLastWord
{
    public int Solve(string s)
    {
        bool isSpace = true;
        int counter = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
                isSpace = false;
            else
                isSpace = true;
            
            if (!isSpace)
                counter++;
            if (counter > 0 && isSpace)
                return counter;
        }

        return counter;
    }

    public void Test()
    {
       
    }
}