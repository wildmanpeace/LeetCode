using BenchmarkDotNet.Attributes;

namespace LeetCode.Benchmarks;

[MemoryDiagnoser]
[ShortRunJob]
public class MedianTwoSortedArrayBenchmarks
{
    private MedianTwoSortedArrays solver = new();
    private List<(int[], int[])> problems = [(new[] {1, 3}, new[] {2}), (new[] {1, 3}, new[] {3, 4})];

    [Benchmark]
    public int Solve1()
    {
        foreach (var problem in problems)
        {
            solver.Solve(problem.Item1, problem.Item2);
        }

        return 0;
    }
    
    [Benchmark]
    public int Solve2()
    {
        foreach (var problem in problems)
        {
            solver.Solve2(problem.Item1, problem.Item2);
        }

        return 0;
    }
}