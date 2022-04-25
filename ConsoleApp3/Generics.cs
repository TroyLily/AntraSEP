using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class Generics
    {
        public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
