using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreApplication.Shell.Helpers
{
    public static class CollectionHelper
    {
        public static bool HasElements<T>(this IEnumerable<T> source)
        {
            return (source != null && source.Any());
        }

        public static IEnumerable<T> Enum<T>(this IEnumerable<T> source)
        {
            return source ?? Enumerable.Empty<T>();
        }

        public static IEnumerable<T> Transverse<T>(this IEnumerable<T> source, Func<T, IEnumerable<T>> fnRecurse)
        {
            foreach (T item in source)
            {
                yield return item;
                IEnumerable<T> seqRecurse = fnRecurse(item);

                if (seqRecurse != null)
                    foreach (T itemRecurse in Transverse(seqRecurse, fnRecurse))
                        yield return itemRecurse;
            }
        }
    }
}
