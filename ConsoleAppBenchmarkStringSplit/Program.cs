using BenchmarkDotNet.Running;
using ConsoleAppBenchmarkStringSplit;

var summary = BenchmarkRunner.Run<BenchmarkTest>();