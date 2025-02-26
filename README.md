# ConsoleAppBenchmarkStringSplit

Benchmark para teste de uso de span vs strin split. Logo abaixo, seguem os resultados.

Logo se nota que ao usar o recurso do dotnet de Span, este consume menos recurso e o tempo de resposta é quase 2x mais rápido. 

```

BenchmarkDotNet v0.14.0, 
.NET SDK 9.0.200-preview.0.25057.12
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 AOT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

```
| Method          | Mean     | Error    | StdDev   | Median   | Gen0   | Allocated |
|---------------- |---------:|---------:|---------:|---------:|-------:|----------:|
| SplitWithSpan   | 149.4 ns |  5.43 ns | 14.94 ns | 145.5 ns | 0.0215 |     136 B |
| SplitWithString | 207.9 ns | 10.39 ns | 30.31 ns | 189.7 ns | 0.0432 |     272 B |