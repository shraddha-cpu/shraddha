using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2, c;
            c=a*b +(a++ + --b) - b;
            Console.WriteLine(c);
        }
    }
}
