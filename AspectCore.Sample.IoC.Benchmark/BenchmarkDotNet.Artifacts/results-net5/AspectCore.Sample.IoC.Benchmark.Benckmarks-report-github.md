``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Intel Xeon CPU E5-2667 v4 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=5.0.203
  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  DefaultJob : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT


```
|                          Method |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|-------:|------:|------:|----------:|
|          Autofac_Sample_Resolve |   452.8 ns |  9.04 ns | 16.77 ns | 2.56 ns |   433.9 ns |   438.0 ns |   447.7 ns |   465.6 ns |   490.1 ns | 2,208,512.1 | 0.0706 |     - |     - |     928 B |
|       AspectCore_Sample_Resolve |   110.7 ns |  2.22 ns |  3.46 ns | 0.61 ns |   106.7 ns |   107.7 ns |   110.0 ns |   112.8 ns |   119.5 ns | 9,029,667.1 | 0.0134 |     - |     - |     176 B |
|       Autofac_PropertyInjection | 1,252.4 ns | 22.31 ns | 29.78 ns | 5.96 ns | 1,223.2 ns | 1,230.1 ns | 1,240.8 ns | 1,266.9 ns | 1,315.7 ns |   798,483.9 | 0.1335 |     - |     - |   1,768 B |
|    AspectCore_PropertyInjection |   378.1 ns |  7.61 ns | 11.39 ns | 2.08 ns |   359.9 ns |   367.4 ns |   377.6 ns |   386.3 ns |   400.9 ns | 2,644,747.8 | 0.0391 |     - |     - |     512 B |
|    Autofac_ConstructorInjection | 1,402.3 ns | 17.69 ns | 13.81 ns | 3.99 ns | 1,386.5 ns | 1,393.3 ns | 1,397.0 ns | 1,406.8 ns | 1,433.6 ns |   713,123.1 | 0.1545 |     - |     - |   2,032 B |
| AspectCore_ConstructorInjection |   380.7 ns |  7.67 ns | 13.63 ns | 2.16 ns |   361.1 ns |   371.4 ns |   375.3 ns |   391.4 ns |   412.1 ns | 2,626,562.3 | 0.0439 |     - |     - |     576 B |
