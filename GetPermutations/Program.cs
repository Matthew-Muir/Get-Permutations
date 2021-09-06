using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
/// <summary>
/// Formula to determine unique pairs in a set.
/// n(n-1)/2 where n is the number of items in the set.
/// 
/// determine unique pairs in a set where N is the total number of items in our set
/// and K is size of our selection set. EXP 6N can be broke into 20 unique sets of 3K.
/// N!/K!(N-K)!
/// 
/// </summary>
namespace GetPermutations
{
    class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "a", "a", "a", "a", "a" };
            var result = GetPermutations(list, 3);

            foreach (var item in result)
            {
                Console.WriteLine(item.ElementAt(0) + item.ElementAt(1) + item.ElementAt(2));
            }
        }
        /// <summary>
        /// int count is the number of items in a set.
        /// items is a list of items used to generate the sets.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                        yield return new T[] { item }.Concat(result);
                }

                ++i;
            }
        }

    }
}