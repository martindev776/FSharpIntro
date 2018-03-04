using CSharp.DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Modules
{
    public static class RecursionModule
    {
        public static void Print()
        {
            var stackOfInts = new Stack<int>();
            for (int i = 1; i <= 10000; i++)
            {
                stackOfInts.Push(i);
            }

            Console.WriteLine(RecursiveSum(stackOfInts));
            //Console.WriteLine(RecursionModule.Sum(stackOfInts));
        }

        public static int RecursiveSum(Stack<int> ints)
        {
            var topInt = ints.Pop();

            return ints.Any()
                ? RecursiveSum(ints) + topInt
                : topInt;
        }

        public static int Sum(Stack<int> intStack)
        {
            var recursiveTailSum = Trampoline.MakeTrampoline((int acc, Stack<int> ints) =>
            {
                var topInt = ints.Pop();
                var total = topInt + acc;

                return ints.Any()
                    ? Trampoline.Recurse<int, Stack<int>, int>(total, ints)
                    : Trampoline.ReturnResult<int, Stack<int>, int>(total);

            });

            return recursiveTailSum(0, intStack);
        }
    }
}
