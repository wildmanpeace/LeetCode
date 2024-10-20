using LeetCode;

namespace LeetCodeTests;

public class LongestSubstringTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData(" ",1)]
    public void SolveTests(string s,  int length)
    {
        //Arrange
        var solver = new LongestSubstring();
        
        //Act
        var result = solver.Solve(s);

        //Assert
        Assert.Equal(length, result);
    }
}