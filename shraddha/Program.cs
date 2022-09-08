using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha
{
    internal class Program
    {
         static void Main(string[] args)        
        {
            int n1 = 10, n2 = 20;
            int result = n1 + n2;
            int multiply = n1* n2;
            int division = n1 / n2;
            int substraction = n1 - n2;
            int modulation = n1 % n2;
            Console.WriteLine($"addition is {result}");
            Console.WriteLine($"multiplication is {multiply}");
            Console.WriteLine($"division is {division}");
            Console.WriteLine($"substraction is {substraction}");
            Console.WriteLine($"modulation is {modulation}");
        }
    }
}
