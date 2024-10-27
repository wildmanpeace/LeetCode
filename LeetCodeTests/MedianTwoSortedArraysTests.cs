using LeetCode;

namespace LeetCodeTests;

public class MedianTwoSortedArraysTests
{
    [Theory]
    [InlineData(new []{1, 3}, new[]{2}, 2)]
    [InlineData(new []{1, 2}, new[]{3,4}, 2.5)]
    public void Solve(int[] arr1, int[] arr2, double answer)
    {
        var solver = new MedianTwoSortedArrays();

        var result = solver.Solve(arr1, arr2);
        
        Assert.Equal(answer, result);
    }
    
}