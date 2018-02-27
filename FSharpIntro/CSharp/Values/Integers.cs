using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Values
{
    public static class Integers
    {
        public static List<int> GetIntegerList(int max)
        {
            var retVal = new List<int>();

            for(int i = 1; i <= max; i++)
            {
                retVal.Add(i);
            }

            return retVal;
        }
    }
}
