using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Helpers
{
    public static class Display
    {
        public static void DisplayListOfIntegers(List<int> integers)
        {
            foreach(var integer in integers)
            {
                Console.WriteLine(integer);
            }            
        }
    }
}
