using CSharp.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Modules
{
    public static class FoldModule
    {

        public static void Print()
        {
            var numbers = Integers.GetIntegerList(3);

            var foldResult = Fold(AccFunction, 0, numbers);
            var foldBackResult = FoldBack(AccFunction, numbers, 0);

            Console.WriteLine("Fold Result: " + foldResult);
            Console.WriteLine("Fold Back Result: " + foldBackResult);
        }

        private static int AccFunction(int acc, int i)
        {
            return acc - i;
        }

        public static int Fold(Func<int, int, int> accFunc, int acc, List<int> numbers)
        {
            foreach(var number in numbers)
            {
                acc = accFunc(acc, number);
            }

            return acc;
        }

        public static int FoldBack(Func<int, int, int> accFunc, List<int> numbers, int acc)
        {
            numbers.Reverse();

            foreach(var number in numbers)
            {
                acc = accFunc(number, acc);
            }

            return acc;
        }
    }    
}
