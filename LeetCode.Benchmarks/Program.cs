// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using LeetCode.Benchmarks;

var results = BenchmarkRunner.Run<LongestSubstringBenchmarks>();