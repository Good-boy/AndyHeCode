using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Framework;

namespace AH.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int iteration = 100 * 1000;
            StringBuilder sb = new StringBuilder();
            CodeTimer.Time("StringBuilder", iteration, () => sb.Append("A"));

            string str = string.Empty;
            CodeTimer.Time("String Concat", iteration, () =>
            {
                str += "A";

            });
            Console.ReadKey();
        }
    }
}
