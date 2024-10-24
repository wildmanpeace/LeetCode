using BenchmarkDotNet.Attributes;

namespace LeetCode.Benchmarks;

[MemoryDiagnoser]
[ShortRunJob]
public class LongestSubstringBenchmarks
{
    private LongestSubstring longestSubstring = new();

    private List<string> useCases = ["abcabcbb", "bbbbb", "pwwkew", " "];

    [Benchmark]
    public int Solve1()
    {
        foreach (var use in useCases)
        {
            _ = longestSubstring.Solve1(use);
        }
        
        return 0;
    }
    
    [Benchmark]
    public int Solve2()
    {
        foreach (var use in useCases)
        {
            _ = longestSubstring.Solve2(use);
        }
        
        return 0;
    }
}