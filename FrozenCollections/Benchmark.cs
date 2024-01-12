using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using System.Collections.Frozen;
using System.Collections.Immutable;

namespace FrozenCollections
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class CreateBenchmark
    {
        private const int itemsCount = 100_000;

        [Benchmark]
        public void CreateDictionary()
        {
            Dictionary<int, int> dictionary = Enumerable.Range(0, itemsCount).ToDictionary(key => key);
        }

        [Benchmark]
        public void CreateImmutableDictionary()
        {
            ImmutableDictionary<int, int> dictionary = Enumerable.Range(0, itemsCount).ToImmutableDictionary(key => key);
        }

        [Benchmark]
        public void CreateFrozenDictionary()
        {
            FrozenDictionary<int, int> frozenDictionary = Enumerable.Range(0, itemsCount).ToFrozenDictionary(key => key);
        }

        [Benchmark]
        public void CreateList()
        {
            List<int> list = Enumerable.Range(0, itemsCount).ToList();
        }

        [Benchmark]
        public void CreateImmutableList()
        {
            ImmutableList<int> list = Enumerable.Range(0, itemsCount).ToImmutableList();
        }

        [Benchmark]
        public void CreateHashSet()
        {
            HashSet<int> hashSet = Enumerable.Range(0, itemsCount).ToHashSet();
        }

        [Benchmark]
        public void CreateImmutableHashSet()
        {
            ImmutableHashSet<int> hashSet = Enumerable.Range(0, itemsCount).ToImmutableHashSet();
        }

        [Benchmark]
        public void CreateFrozenSet()
        {
            FrozenSet<int> frozenSet = Enumerable.Range(0, itemsCount).ToFrozenSet();
        }
    }

    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class TryGetValueBenchmark
    {
        private const int itemsCount = 100_000;
        private const int keyToFind = 5_000;

        private Dictionary<int, int> _dictionary = Enumerable.Range(0, itemsCount).ToDictionary(key => key);
        private ImmutableDictionary<int, int> _immutableDictionary = Enumerable.Range(0, itemsCount).ToImmutableDictionary(key => key);
        
        private HashSet<int> _hashSet = Enumerable.Range(0, itemsCount).ToHashSet();
        private ImmutableHashSet<int> _immutableHashSet = Enumerable.Range(0, itemsCount).ToImmutableHashSet();
        
        private FrozenDictionary<int, int> _frozenDictionary = Enumerable.Range(0, itemsCount).ToFrozenDictionary(key => key);
        private FrozenSet<int> _frozenSet = Enumerable.Range(0, itemsCount).ToFrozenSet();

        [Benchmark]
        public void TryGetValueDictionary()
        {
            _dictionary.TryGetValue(keyToFind, out _);
        }

        [Benchmark]
        public void TryGetValueImmutableDictionary()
        {
            _immutableDictionary.TryGetValue(keyToFind, out _);
        }

        [Benchmark]
        public void TryGetValueFrozenDictionary()
        {
            _frozenDictionary.TryGetValue(keyToFind, out _);
        }

        [Benchmark]
        public void TryGetValueHashSet()
        {
            _hashSet.TryGetValue(keyToFind, out _);
        }

        [Benchmark]
        public void TryGetValueImmutableHashSet()
        {
            _immutableHashSet.TryGetValue(keyToFind, out _);
        }

        [Benchmark]
        public void TryGetValueFrozenSet()
        {
            _frozenSet.TryGetValue(keyToFind, out _);
        }
    }

    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class LookupBenchmark
    {
        private const int itemsCount = 100_000;
        private const int iterations = 1_000;

        private Dictionary<int, int> _dictionary = Enumerable.Range(0, itemsCount).ToDictionary(key => key);
        private ImmutableDictionary<int, int> _immutableDictionary = Enumerable.Range(0, itemsCount).ToImmutableDictionary(key => key);

        private List<int> _list = Enumerable.Range(0, itemsCount).ToList();
        private ImmutableList<int> _immutableList = Enumerable.Range(0, itemsCount).ToImmutableList();

        private HashSet<int> _hashSet = Enumerable.Range(0, itemsCount).ToHashSet();
        private ImmutableHashSet<int> _immutableHashSet = Enumerable.Range(0, itemsCount).ToImmutableHashSet();

        private FrozenDictionary<int, int> _frozenDictionary = Enumerable.Range(0, itemsCount).ToFrozenDictionary(key => key);
        private FrozenSet<int> _frozenSet = Enumerable.Range(0, itemsCount).ToFrozenSet();

        [Benchmark]
        public void LookupDictionary()
        {
            for (int i = 0; i < iterations; i++)
                _ = _dictionary.ContainsKey(i);
        }

        [Benchmark]
        public void LookupImmutableDictionary()
        {
            for (int i = 0; i < iterations; i++)
                _ = _immutableDictionary.ContainsKey(i);
        }

        [Benchmark]
        public void LookupFrozenDictionary()
        {
            for (var i = 0; i < iterations; i++)
                _ = _frozenDictionary.ContainsKey(i);
        }

        [Benchmark]
        public void LookupList()
        {
            for (int i = 0; i < iterations; i++)
                _ = _list.Contains(i);
        }

        [Benchmark]
        public void LookupImmutableList()
        {
            for (int i = 0; i < iterations; i++)
                _ = _immutableList.Contains(i);
        }

        [Benchmark]
        public void LookupHashSet()
        {
            for (var i = 0; i < iterations; i++)
                _ = _hashSet.Contains(i);
        }

        [Benchmark]
        public void LookupImmutableHashSet()
        {
            for (var i = 0; i < iterations; i++)
                _ = _immutableHashSet.Contains(i);
        }

        [Benchmark]
        public void LookupFrozenSet()
        {
            for (var i = 0; i < iterations; i++)
                _ = _frozenSet.Contains(i);
        }
    }
}