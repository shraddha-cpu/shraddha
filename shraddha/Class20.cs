using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha
{
    internal class Class20
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("1.for eng");
             Console.WriteLine("2.for hindi");
             Console.WriteLine("3.for marathi");
             Console.WriteLine("select your option");
             int num=Convert.ToInt32(Console.ReadLine());
             switch(num)
             {
                 case 1:
                     Console.WriteLine("you have selected eng lang");
                     break;
                 case 2:
                     Console.WriteLine("you have selected hindi lang");
                     break;
                 case 3:
                     Console.WriteLine("you have selected marathi lang");
                     break;
                 default:
                     Console.WriteLine("wrong input");
                     break; */
            Console.WriteLine("enter n1");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter n2");
            int b=Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("1.addition");
            Console.WriteLine("2.substraction");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.division");
            Console.WriteLine("5.mod");
            Console.WriteLine("select your option");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine("you have selected addition "+(a+b));
                    break;
                case 2:
                    Console.WriteLine("you have selected substraction "+(a-b));
                    break;
                case 3:
                    Console.WriteLine("you have selected multiplication "+(a*b));
                    break;
                case 4:
                    Console.WriteLine("you have selected division"+(a/b));
                    break;
                case 5:
                    Console.WriteLine("you have selected mod"+(a%b));
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
                    
            }
        }
    }
}