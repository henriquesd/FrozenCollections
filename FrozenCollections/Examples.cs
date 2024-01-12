using System.Collections.Frozen;
using System.Collections.Immutable;

namespace FrozenCollections
{
    public static class Examples
    {
        public static void DictionaryDemo()
        {
            var dictionary = Enumerable.Range(0, 10).ToDictionary(key => key);

            Console.WriteLine("Dictionary: " + string.Join(" ", dictionary));
        }

        public static void ImmutableDictionaryDemo()
        {
            var immutableDictionary = Enumerable.Range(0, 10).ToImmutableDictionary(key => key);

            Console.WriteLine("ImmutableDictionary: " + string.Join(" ", immutableDictionary));
        }

        public static void FrozenDictionaryDemo()
        {
            var frozenDictionary = Enumerable.Range(0, 10).ToFrozenDictionary(key => key);

            Console.WriteLine("FrozenDictionary: " + string.Join(" ", frozenDictionary));
        }

        public static void ListDemo()
        {
            var list = Enumerable.Range(0, 10).ToList();

            Console.WriteLine("List: " + string.Join(" ", list));
        }

        public static void ImmutableListDemo()
        {
            var immutableList = Enumerable.Range(0, 10).ToImmutableList();

            Console.WriteLine("ImmutableList: " + string.Join(" ", immutableList));
        }

        public static void HashSetDemo()
        {
            var hashSet = Enumerable.Range(0, 10).ToHashSet();

            Console.WriteLine("HashSet: " + string.Join(" ", hashSet));
        }

        public static void ImmutableHashSetDemo()
        {
            var immutableHashSet = Enumerable.Range(0, 10).ToImmutableHashSet();

            Console.WriteLine("ImmutableHashSet: " + string.Join(" ", immutableHashSet));
        }

        public static void FrozenSetDemo()
        {
            var frozenSet = Enumerable.Range(0, 10).ToFrozenSet();

            Console.WriteLine("FrozenSet: " + string.Join(" ", frozenSet));
        }
    }
}