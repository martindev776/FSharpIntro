using CSharp.Helpers;
using CSharp.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Modules
{
    public static class FilterModule
    {
        public static void Print()
        {
            var integers1To10 = Integers.GetIntegerList(10);
            var evenIntegers = GetEvenNumbers(integers1To10);
            var evenIntegersLinq = GetEvenIntegersLinq(integers1To10);

            Display.DisplayListOfIntegers(evenIntegers);
            Display.DisplayListOfIntegers(evenIntegersLinq);
        }

        public static List<int> GetEvenNumbers(List<int> integers)
        {
            var retVal = new List<int>();

            foreach(var integer in integers)
            {
                if (IsEven(integer))
                    retVal.Add(integer);
            }

            return retVal;
        }

        public static List<int> GetEvenIntegersLinq(List<int> integers)
        {
            return integers.Where(x => IsEven(x)).ToList();
        }

        private static bool IsEven(int i)
        {
            return i % 2 == 0;
        }
    }
}
