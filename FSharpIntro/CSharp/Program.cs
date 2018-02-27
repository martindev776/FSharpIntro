using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Values;
using CSharp.Modules;
using CSharp.Helpers;

namespace CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var integers1To10 = Integers.GetIntegerList(10);
            var evenIntegers = FilterModule.GetEvenNumbers(integers1To10);
            var evenIntegersLinq = FilterModule.GetEvenIntegersLinq(integers1To10);

            Display.DisplayListOfIntegers(evenIntegers);
            Display.DisplayListOfIntegers(evenIntegersLinq);

            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}
