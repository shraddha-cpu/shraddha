using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine($"{a++} {a++} {++a}");
            Console.WriteLine($"{a++} {--a} {++a}");
            Console.WriteLine($"{a++} {--a} {--a} {a++} {++a}");
        }
    }
}
