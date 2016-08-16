using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
// <copyright file="CollectionExtensionsTest.cs" company="dotNetTips.com">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Portable.Extensions;

namespace dotNetTips.Utility.Portable.Extensions.Tests
{
    [TestClass]
    [PexClass(typeof(CollectionExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CollectionExtensionsTest
    {

        [PexMethod]
        public bool ContainsAny(string input, string[] characters)
        {
            bool result = CollectionExtensions.ContainsAny(input, characters);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.ContainsAny(String, String[])
        }

        [PexMethod]
        public int Count(IEnumerable source)
        {
            int result = CollectionExtensions.Count(source);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.Count(IEnumerable)
        }

        [PexMethod]
        public string[] NoDuplicates(string[] source)
        {
            string[] result = CollectionExtensions.NoDuplicates(source);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.NoDuplicates(String[])
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<IEnumerable<T>> Page<T>(IEnumerable<T> source, int pageSize)
        {
            IEnumerable<IEnumerable<T>> result = CollectionExtensions.Page<T>(source, pageSize);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.Page(IEnumerable`1<!!0>, Int32)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> PickRandom<T>(IEnumerable<T> source, int count)
        {
            IEnumerable<T> result = CollectionExtensions.PickRandom<T>(source, count);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.PickRandom(IEnumerable`1<!!0>, Int32)
        }

        [PexGenericArguments(new Type[] { typeof(int), typeof(int), typeof(int), typeof(int) })]
        [PexMethod]
        public Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> Pivot<TSource, TFirstKey, TSecondKey, TValue>(
            IEnumerable<TSource> source,
            Func<TSource, TFirstKey> firstKeySelector,
            Func<TSource, TSecondKey> secondKeySelector,
            Func<IEnumerable<TSource>, TValue> aggregate
        )
        {
            Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> result
               = CollectionExtensions.Pivot<TSource, TFirstKey, TSecondKey, TValue>
                     (source, firstKeySelector, secondKeySelector, aggregate);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.Pivot(IEnumerable`1<!!0>, Func`2<!!0,!!1>, Func`2<!!0,!!2>, Func`2<IEnumerable`1<!!0>,!!3>)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> Randomize<T>(IEnumerable<T> source)
        {
            IEnumerable<T> result = CollectionExtensions.Randomize<T>(source);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.Randomize(IEnumerable`1<!!0>)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public string ToDelimitedString<T>(IEnumerable<T> source, char delimiter)
        {
            string result = CollectionExtensions.ToDelimitedString<T>(source, delimiter);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.ToDelimitedString(IEnumerable`1<!!0>, Char)
        }

        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(IEnumerable<IGrouping<TKey, TValue>> source)
        {
            Dictionary<TKey, List<TValue>> result = CollectionExtensions.ToDictionary<TKey, TValue>(source);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.ToDictionary(IEnumerable`1<IGrouping`2<!!0,!!1>>)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public Task<List<T>> ToListAsync<T>(IEnumerable<T> source)
        {
            Task<List<T>> result = CollectionExtensions.ToListAsync<T>(source);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.ToListAsync(IEnumerable`1<!!0>)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public ObservableCollection<T> ToObservableCollection<T>(IEnumerable<T> source)
        {
            ObservableCollection<T> result = CollectionExtensions.ToObservableCollection<T>(source);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.ToObservableCollection(IEnumerable`1<!!0>)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public ReadOnlyCollection<T> ToReadOnlyCollection<T>(IList<T> source)
        {
            ReadOnlyCollection<T> result = CollectionExtensions.ToReadOnlyCollection<T>(source);
            return result;
            // TODO: add assertions to method CollectionExtensionsTest.ToReadOnlyCollection(IList`1<!!0>)
        }
    }
}
