using System.Text;

namespace LeetCode;

public class ZigZagConvo
{
    public string Solve(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }
        var width = TotalWidth(s, numRows);
        var charArr = s.ToCharArray();
        int counter = 0;

        char[,] convo = new char[numRows, width];

        for (int i = 0; i < width; i++) //Column
        {
            for (int j = 0; j <= numRows - 1; j++) //Row
            {
                //down
                convo[j, i] = charArr[counter];
                counter++;

                if (counter > s.Length - 1)
                {
                    break;
                }
            }
            
            if (counter > s.Length - 1)
            {
                break;
            }

            //up
            for (int k = numRows - 2; k > 0; k--)
            {
                i++;
                convo[k, i] = charArr[counter];
                counter++;
                
                if (counter > s.Length - 1)
                {
                    break;
                }
            }
            
            if (counter > s.Length - 1)
            {
                break;
            }
        }
        
        
        //Build string
        StringBuilder builder = new();
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (convo[i,j] != '\0')
                {
                    builder.Append(convo[i, j]);   
                }
            }
        }
        
        
        return builder.ToString();
    }

    public int TotalWidth(string s, int numRows)
    {
        int sLength = s.Length;
        int width = 0;

        while (sLength >= 0)
        {
            //Down
            width += 1;
            sLength -= numRows;

            width += numRows - 2;
            sLength -= numRows - 2;
        }
        
        return width;
    }
}