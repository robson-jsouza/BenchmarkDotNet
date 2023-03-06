// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarkDotNetPOC.Benchmarks;

var summary = BenchmarkRunner.Run<DateParserBenchmarks >();
