namespace LeetCode;

public class LongestSubstring
{
    public int Solve1(string s)
    {
        int answer = 0;
        if (s.Length is 1)
        {
            return 1;
        }

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (answer > s.Length - i)
            {
                return answer;
            }
            int counter = 1;
            (string curSubstring, int curLength) temp = (s[i].ToString(), 1);
            if (answer is 0)
            {
                answer = 1;
            }

            while (i + counter < s.Length && !temp.curSubstring.Contains(s[i + counter]))
            {
                temp = (temp.curSubstring += s[i + counter], temp.curLength+=1);
                if (answer < temp.curLength)
                {
                    answer = temp.curLength;
                }

                counter++;
            }

        }

        return answer;
    }
    
    public int Solve2(string s)
    {
        
        int answer = 0;
        if (s.Length is 1)
        {
            return 1;
        }

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (answer > s.Length - i)
            {
                return answer;
            }
            int counter = 1;
            (string curSubstring, int curLength) temp = (s[i].ToString(), 1);
            if (answer is 0)
            {
                answer = 1;
            }

            while (i + counter < s.Length && !temp.curSubstring.Contains(s[i + counter]))
            {
                temp = (temp.curSubstring += s[i + counter], temp.curLength+=1);
                if (answer < temp.curLength)
                {
                    answer = temp.curLength;
                }
                counter++;
            }

            if (counter - 1 > i)
            {
                i += counter - 1;
            }
        }

        return answer;
    }
}