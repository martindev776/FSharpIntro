using CSharp.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Modules
{
    public static class BasicsModule
    {
        public static void SimilarToLinq()
        {
            var numbers = Integers.GetIntegerList(10);

            var multedBy2 = numbers.Select(MultBy2);
            var numbersLessThan4 = numbers.Where(x => x < 4);
        }

        public static List<int> Piping()
        {
            var numbers = Integers.GetIntegerList(10);

            return numbers.Select(MultBy2).Where(LessThan6).ToList();
        }

        public static int MultBy2(int number)
        {
            return number * 2;
        }        

        public static bool LessThan6(int x)
        {
            return x < 6;
        }
    }
}
