﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SuperExtensions
{
    public static class AssemblyExtensions
    {
        //Attribute
        public static T GetCustomAttribute<T>(this Assembly element, bool inherit) where T : Attribute => (T)Attribute.GetCustomAttribute(element, typeof(T), inherit);
        public static IEnumerable<T> GetCustomAttributes<T>(this Assembly element, bool inherit) where T : Attribute => Attribute.GetCustomAttributes(element, typeof(T), inherit).Cast<T>();
        public static bool IsDefined<T>(Assembly element) where T : Attribute => Attribute.IsDefined(element, typeof(T));
        public static bool IsDefined<T>(Assembly element, bool inherit) where T : Attribute => Attribute.IsDefined(element, typeof(T), inherit);
    }
}