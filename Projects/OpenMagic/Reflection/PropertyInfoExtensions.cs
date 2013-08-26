﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace OpenMagic.Reflection
{
    public static class PropertyInfoExtensions
    {
        public static T GetCustomAttribute<T>(this PropertyInfo value)
        {
            value.MustNotBeNull("value");

            return value.GetCustomAttributes<T>().SingleOrDefault();
        }

        public static IEnumerable<T> GetCustomAttributes<T>(this PropertyInfo value)
        {
            value.MustNotBeNull("value");

            return value.GetCustomAttributes(typeof(T), true).Cast<T>();
        }

        public static bool IsDecoratedWith<T>(this PropertyInfo value)
        {
            value.MustNotBeNull("value");

            return value.GetCustomAttributes<T>().Any();
        }

        public static bool IsRequired(this PropertyInfo value)
        {
            value.MustNotBeNull("value");

            return value.IsDecoratedWith<RequiredAttribute>();
        }
    }
}
