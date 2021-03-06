﻿using System;

namespace Extensions
{
    public static class ComparableExtensions
    {
        public static bool IsBetween<T>(this T x, T low, T high) where T : IComparable<T>
        {
            return x.CompareTo(low) >= 0 && x.CompareTo(high) <= 0;
        }

        public static bool IsBiggerThan<T>(this T x, T low) where T : IComparable<T>
        {
            return x.CompareTo(low) >= 0;
        }

        public static bool IsSmallerThan<T>(this T x, T high) where T : IComparable<T>
        {
            return x.CompareTo(high) <= 0;
        }
    }
}
