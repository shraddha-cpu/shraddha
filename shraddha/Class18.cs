using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha
{
    internal class Class18
    {
        static void Main(string[] args)
        {
            int i, fact = 1, n;
            Console.WriteLine("Enter  Number ");
            n=int.Parse(Console.ReadLine());
            for (i=1; i<=n; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine($"factorial no is" +n+ "is"+fact);
        }
    }
}
