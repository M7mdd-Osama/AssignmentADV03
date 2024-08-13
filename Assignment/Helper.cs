using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Helper<T>
    {
        public static bool Exist(List<T> list, Predicate<T> match)
        {
            foreach (T item in list)
                if (match(item))
                {
                    return true;
                }
            return false;
        }

        public static T Find(List<T> list, Predicate<T> match)
        {
            foreach (T item in list)
                if (match(item))
                {
                    return item;
                }
            return default(T);
        }

        public static List<T> FindAll(List<T> list, Predicate<T> match)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
                if (match(item))
                {
                    result.Add(item);
                }
            return result;
        }

        public static int FindIndex(List<T> list, Predicate<T> match)
        {
            for (int i = 0; i < list.Count; i++)
                if (match(list[i]))
                {
                    return i;
                }
            return -1;
        }

        public static T FindLast(List<T> list, Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
                if (match(list[i]))
                {
                    return list[i];
                }
            return default(T);
        }

        public static int FindLastIndex(List<T> list, Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
                if (match(list[i]))
                {
                    return i;
                }
            return -1;
        }

        public static void ForEach(List<T> list, Action<T> action)
        {
            foreach (T item in list)
            {
                action(item);
            }
        }

        public static bool TrueForAll(List<T> list, Predicate<T> match)
        {
            foreach (T item in list)
                if (!match(item))
                {
                    return false;
                }
            return true;
        }
    }
}
