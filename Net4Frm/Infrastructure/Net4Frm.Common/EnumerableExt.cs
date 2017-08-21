using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class EnumerableExt
    {
        //public static bool IsHasRow<T>(this IEnumerable<T> enumerable) where T : class
        //{
        //    bool flag = null != enumerable && enumerable.Any();
        //    return flag;
        //}

        public static bool IsHasRow<T>(this IEnumerable<T> enumerable)
        {
            bool flag = null != enumerable && enumerable.Any();
            return flag;
        }

    }
}
