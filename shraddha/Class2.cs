using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum = n1 + n2;
            Console.WriteLine($"addition is {sum}");
        }
    }
}
