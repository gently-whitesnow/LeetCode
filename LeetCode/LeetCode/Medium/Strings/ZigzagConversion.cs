using System;
using System.Text;

namespace LeetCode.Medium.Strings;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) {
            return s;
        }
        
        StringBuilder answer = new StringBuilder();
        int n = s.Length;
        int charsInSection = 2 * (numRows - 1);
        
        for (int currRow = 0; currRow < numRows; ++currRow) {
            int index = currRow;

            while (index < n) {
                answer.Append(s[index]);
                
                if (currRow != 0 && currRow != numRows - 1) {
                    int charsInBetween = charsInSection - 2 * currRow;
                    int secondIndex = index + charsInBetween;
                    
                    if (secondIndex < n) {
                        answer.Append(s[secondIndex]);
                    }
                }
                index += charsInSection;
            }
        }
        
        return answer.ToString();
    }

    public void Test()
    {
        Console.WriteLine(Convert("abcdefghihklmnopqrstuvwxyz",5));
    }
}