using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2, c, d, e, f;
            c=a++ - b--;
            d=--a + ++b;
            e=++a - ++b;
            f=--a  * b--;
            Console.WriteLine(c);
            Console.WriteLine(d);   
            Console.WriteLine(e);   
            Console.WriteLine(f);
        }
    }
}
