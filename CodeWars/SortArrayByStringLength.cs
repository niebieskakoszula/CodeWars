using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Core
{
    public static class SortArrayByStringLength
    {
        public static string[] SortByLength(string[] array)
        {
            return array.OrderBy(e => e.Length).ToArray();
        }
    }
}
