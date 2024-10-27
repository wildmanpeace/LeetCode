namespace LeetCode;

public class MedianTwoSortedArrays
{
    public double Solve(int[] nums1, int[] nums2)
    {
        var combined = nums1.Concat(nums2).Order().ToArray();
        var middle = (double)combined.Length / 2;
        
        if (combined.Length % 2 != 0)
        {
            return combined[(int)middle];
        }

        return (double)(combined[(int) middle] + combined[(int) middle - 1]) / 2;
    }
    
    public double Solve2(int[] nums1, int[] nums2)
    {
        var combined = new Span<int>(nums1.Concat(nums2).Order().ToArray());
        var middle = (double)combined.Length / 2;
        
        if (combined.Length % 2 != 0)
        {
            return combined[(int)middle];
        }

        return (double)(combined[(int) middle] + combined[(int) middle - 1]) / 2;
    }
}