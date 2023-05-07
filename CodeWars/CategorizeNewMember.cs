using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Core
{
    public static class CategorizeNewMember
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            foreach (var member in data)
            {
                if (55 <= member[0] && 7 < member[1])
                    yield return "Senior";
                else
                    yield return "Open";
            }
        }
    }
}
