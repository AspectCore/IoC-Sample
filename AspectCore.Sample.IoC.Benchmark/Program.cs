using System;

namespace AspectCore.Sample.IoC.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkDotNet.Running.BenchmarkRunner.Run<Benckmarks>();
        }
    }
}
