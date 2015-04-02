﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NullGuard;
using OpenMagic.Extensions;

namespace OpenMagic
{
    /// <summary>
    ///     Collection of argument testing methods.
    /// </summary>
    public static class Argument
    {
        /// <summary>
        ///     Throws <see cref="ArgumentException" /> when assertion on <paramref name="param" /> has failed.
        /// </summary>
        /// <typeparam name="T">The <paramref name="param" /> type.</typeparam>
        /// <param name="param">The value that was tested.</param>
        /// <param name="assertionResult">The result of the assertion on <paramref name="param" />.</param>
        /// <param name="message">The exception message to use when <paramref name="assertionResult" /> is false.</param>
        /// <param name="paramName">The name of the parameter being tested.</param>
        /// <returns>Returns <paramref name="param" /> when the value is not null.</returns>
        public static T Must<T>(this T param, bool assertionResult, string message, string paramName)
        {
            if (!assertionResult)
            {
                throw new ArgumentException(message, paramName);
            }

            return param;
        }

        public static T MustBeGreaterThan<T>(this T param, T greaterThan, string paramName) where T : IComparable<T>
        {
            if (param.CompareTo(greaterThan) > 0)
            {
                return param;
            }

            var exception = new ArgumentOutOfRangeException(paramName, String.Format("Value must be greater than {0}.", greaterThan));

            exception.Data.Add("param", param);
            exception.Data.Add("greaterThan", greaterThan);
            exception.Data.Add("paramName", paramName);

            throw exception;

        }

        public static T[] MustNotBeEmpty<T>(this T[] param, string paramName)
        {
            // todo: test & document
            if (!param.Any())
            {
                throw new ArgumentException("Value cannot be empty.", paramName);
            }

            return param;
        }

        /// <summary>
        ///     Throws <see cref="ArgumentNullException" /> when <paramref name="param" /> is null.
        /// </summary>
        /// <typeparam name="T">The <paramref name="param" /> type.</typeparam>
        /// <param name="param">The value to test for null.</param>
        /// <param name="paramName">The name of the parameter being tested.</param>
        /// <returns>Returns <paramref name="param" /> when the value is not null.</returns>
        public static T MustNotBeNull<T>([AllowNull] this T param, string paramName)
        {
            // ReSharper disable once CompareNonConstrainedGenericWithNull
            if (param == null)
            {
                throw new ArgumentNullException(paramName);
            }

            return param;
        }

        /// <summary>
        ///     Throws <see cref="ArgumentNullException" /> when <paramref name="param" /> is null or
        ///     <see cref="ArgumentException" /> when <paramref name="param" /> is empty.
        /// </summary>
        /// <typeparam name="T">The <paramref name="param" /> type.</typeparam>
        /// <param name="param">The value to test for null or empty.</param>
        /// <param name="paramName">The name of the parameter being tested.</param>
        /// <returns>Returns <paramref name="param" /> when the value is not null.</returns>
        public static IEnumerable<T> MustNotBeNullOrEmpty<T>([AllowNull] this IEnumerable<T> param, string paramName)
        {
            // ReSharper disable once PossibleMultipleEnumeration
            if (!param.Any())
            {
                throw new ArgumentException("Value cannot be empty.", paramName);
            }

            // ReSharper disable once PossibleMultipleEnumeration
            return param;
        }

        /// <summary>
        ///     Throws <see cref="ArgumentNullException" /> when <paramref name="param" /> is null or
        ///     <see cref="ArgumentException" /> when <paramref name="param" /> is whitespace.
        /// </summary>
        /// <param name="param">The value to test for null or whitespace.</param>
        /// <param name="paramName">The name of the parameter being tested.</param>
        /// <returns>Returns <paramref name="param" /> when the value is not null or whitespace.</returns>
        public static string MustNotBeNullOrWhiteSpace([AllowNull] this string param, string paramName)
        {
            param.MustNotBeNull(paramName);

            if (param.IsNullOrWhiteSpace())
            {
                throw new ArgumentException("Value cannot be whitespace.", paramName);
            }

            return param;
        }

        public static FileInfo FileMustExist(FileInfo param, string paramName)
        {
            if (!param.Exists)
            {
                throw new ArgumentException("File must exist.", paramName, new FileNotFoundException("Cannot find file.", param.FullName));
            }
            return param;
        }
    }
}