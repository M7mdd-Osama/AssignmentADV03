using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class CompareFunctions
    {
        public static bool CompareGrt(int X, int Y)
        {
            return X > Y;
        }
        public static bool CompareLess(int X, int Y)
        {
            return X < Y;
        }
        public static bool SortAscending(string X, string Y)
        {
            return X?.Length > Y?.Length;
        }
        public static bool SortDescending(string X, string Y)
        {
            return X?.Length < Y?.Length;
        }
    }
}
