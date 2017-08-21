using System.Collections.Generic;

namespace Net4Frm.Logging.Extend
{
    internal static class ListExtend
    {
        public static void AddSynchronized<T>(this IList<T> list, T t)
        {
            lock (list)
            {
                list.Add(t);
            }
        }
    }
}
