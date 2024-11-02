using LeetCode;

namespace LeetCodeTests;

public class ZigZagConvoTests
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    [InlineData("ABCD", 3, "ABDC")]
    public void Solve_Tests(string s, int numRows, string expected)
    {
        var solver = new ZigZagConvo();

        var result = solver.Solve(s, numRows);
        
        Assert.Equal(expected, result);
    }
}