using BenchmarkDotNet.Running;
using FrozenCollections;

//Examples.DictionaryDemo();
//Examples.ImmutableDictionaryDemo();
//Examples.FrozenDictionaryDemo();
//Examples.ListDemo();
//Examples.ImmutableListDemo();
//Examples.HashSetDemo();
//Examples.ImmutableHashSetDemo();
//Examples.FrozenSetDemo();

BenchmarkRunner.Run<CreateBenchmark>();
BenchmarkRunner.Run<TryGetValueBenchmark>();
BenchmarkRunner.Run<LookupBenchmark>();
