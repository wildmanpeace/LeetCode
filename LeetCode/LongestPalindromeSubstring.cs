using System.Net;
using System.Text;

namespace LeetCode;

public class LongestPalindromeSubstring
{
    public string Solve(string s)
    {
        var reverse = ReverseToString(s);
        if (reverse == s)
        {
            return s;
        }

        string longestPalindrome = string.Empty;

        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = longestPalindrome.Length; j <= s.Length - 1; j++)
            {
                if (j > s.Length - i)
                {
                    break;
                }

                var temp = s.Substring(i, j);
                var tempReverse = ReverseToString(temp);
                if (temp == tempReverse && temp.Length > longestPalindrome.Length)
                {
                    longestPalindrome = temp;
                }
            }
        }

        return longestPalindrome;
    }

    private static string ReverseToString(string toReverse)
    {
        var reversedString = toReverse.Reverse();

        StringBuilder builder = new StringBuilder();
        foreach (var c in reversedString)
        {
            builder.Append(c);
        }

        return builder.ToString();
    }
}