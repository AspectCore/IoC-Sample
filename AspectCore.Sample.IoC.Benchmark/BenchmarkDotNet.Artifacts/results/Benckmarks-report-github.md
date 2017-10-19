``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Threshold 2 (10.0.10586)
Processor=Intel Core i5-4590 CPU 3.30GHz (Haswell), ProcessorCount=4
Frequency=3215206 Hz, Resolution=311.0221 ns, Timer=TSC
dotnet cli version=2.0.0
  [Host]     : .NET Core 4.6.00001.0, 64bit RyuJIT [AttachedDebugger]
  DefaultJob : .NET Core 4.6.00001.0, 64bit RyuJIT


```
 |                          Method |        Mean |     Error |    StdDev |    StdErr |         Min |          Q1 |      Median |          Q3 |         Max |         Op/s |  Gen 0 | Allocated |
 |-------------------------------- |------------:|----------:|----------:|----------:|------------:|------------:|------------:|------------:|------------:|-------------:|-------:|----------:|
 |          Autofac_Sample_Resolve |   494.83 ns | 7.1052 ns | 6.6462 ns | 1.7161 ns |   482.52 ns |   490.19 ns |   495.53 ns |   499.97 ns |   506.58 ns |  2,020,908.9 | 0.2384 |     752 B |
 |       AspectCore_Sample_Resolve |    88.52 ns | 0.5246 ns | 0.4651 ns | 0.1243 ns |    87.92 ns |    88.16 ns |    88.47 ns |    88.86 ns |    89.31 ns | 11,296,837.3 | 0.0279 |      88 B |
 |       Autofac_PropertyInjection | 2,014.46 ns | 8.3943 ns | 7.4413 ns | 1.9888 ns | 2,004.18 ns | 2,008.05 ns | 2,012.60 ns | 2,018.61 ns | 2,028.83 ns |    496,411.0 | 0.5875 |    1856 B |
 |    AspectCore_PropertyInjection |   307.55 ns | 2.0800 ns | 1.9457 ns | 0.5024 ns |   303.61 ns |   306.21 ns |   307.10 ns |   308.93 ns |   310.74 ns |  3,251,544.6 | 0.1063 |     336 B |
 |    Autofac_ConstructorInjection | 1,465.71 ns | 8.7514 ns | 8.1861 ns | 2.1136 ns | 1,454.43 ns | 1,458.12 ns | 1,466.01 ns | 1,473.38 ns | 1,480.38 ns |    682,263.5 | 0.6084 |    1920 B |
 | AspectCore_ConstructorInjection |   284.94 ns | 0.7656 ns | 0.6393 ns | 0.1773 ns |   283.55 ns |   284.60 ns |   284.96 ns |   285.43 ns |   286.05 ns |  3,509,500.8 | 0.0987 |     312 B |
