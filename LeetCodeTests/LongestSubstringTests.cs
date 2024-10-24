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
        var result = solver.Solve1(s);

        //Assert
        Assert.Equal(length, result);
    }
    
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData(" ",1)]
    public void Solve2Tests(string s,  int length)
    {
        //Arrange
        var solver = new LongestSubstring();
        
        //Act
        var result = solver.Solve2(s);

        //Assert
        Assert.Equal(length, result);
    }
}