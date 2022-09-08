using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c, d, e, f;
            c= a++ + --b;
            d= --a - b--;
            e=--a + --b;
            f=a++ * --b;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
