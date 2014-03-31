﻿using System.Collections;
using System.Collections.Generic;

namespace OpenMagic.Collections.Generic
{
    /// <summary>
    ///     Provides a base class for classes that need to implement <see cref="IEnumerable<T>"/>.
    /// </summary>
    /// <typeparam name="T">
    ///     The type of elements in the collection.
    /// </typeparam>
    public abstract class EnumerableBase<T> : IEnumerable<T>
    {
        /// <summary>
        ///     Initializes a new instance of the Collection<T> class that is empty.
        /// </summary>
        protected EnumerableBase()
        {
            Items = new List<T>();
        }

        /// <summary>
        ///     Gets the items this class can enumerate
        /// </summary>
        protected IList<T> Items { get; set; }

        /// <summary>
        ///     Returns an enumerator that iterates through the collection.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        /// <summary>
        ///     Returns a non-generic enumerator that iterates through the collection.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}