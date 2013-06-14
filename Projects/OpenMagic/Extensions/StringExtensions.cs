﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Common.Logging;

namespace OpenMagic.Extensions
{
    public static class StringExtensions
    {
        private static readonly ILog log = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Get the values in a string that are between a pair of delimiters.
        /// </summary>
        /// <param name="value">The string to search.</param>
        /// <param name="delimiter">The value delimiter.</param>
        /// <example>
        /// GetValuesBetween("a 'quick' brown 'fox'") => { "quick", "fox }.
        /// </example>
        public static IEnumerable<string> GetValuesBetween(this string value, string delimiter)
        {
            log.Trace(m => m("GetValuesBetween(value: '{0}', delimiter: '{1}')", value, delimiter));

            // todo: replace with Argument.MustNotBeNull() or similar.
            if (delimiter == null) { throw new ArgumentNullException("delimiter"); }
            if (delimiter.IsNullOrWhiteSpace()) { throw new ArgumentException("Value cannot be whitespace.", "delimiter"); }
            if (delimiter.Length > 1) { throw new ArgumentException("Value cannot be longer than 1 character.", "delimiter"); }

            if (value == null)
            {
                return Enumerable.Empty<string>();
            }

            var split = value.Split(Convert.ToChar(delimiter));
            var values = new List<string>();

            for (int i = 1; i < split.Count(); i = i + 2)
            {
                // todo: yield return split[i] should work but it breaks String.IsNullOrWhiteSpace(delimiter) test.
                values.Add(split[i]);
            }

            return values;
        }

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <remarks>
        /// Syntactic sugar.
        /// </remarks>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Splits a string value into lines.
        /// </summary>
        /// <param name="value">The string to split into lines.</param>
        public static IEnumerable<string> ToLines(this string value)
        {
            return value.ToLines(false);
        }

        /// <summary>
        /// Splits a string value into lines.
        /// </summary>
        /// <param name="value">The string to split into lines.</param>
        /// <param name="trimLines">If true the lines are trimmed.</param>
        public static IEnumerable<string> ToLines(this string value, bool trimLines)
        {
            if (value == null)
            {
                return Enumerable.Empty<string>();
            }

            var lines = new List<string>();
            var reader = new StringReader(value);

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (trimLines)
                {
                    lines.Add(line.Trim());
                }
                else
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}
