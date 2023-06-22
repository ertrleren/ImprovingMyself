using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 20;

            if (number >=0 &&number<=100) // Number büyük eşittir 0 ise  ve number küçük eşittir 100 ise     & = ve
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number >100 &&number<=200) // sayının 100 ile 200 arasında olup olmadığı
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number >200|| number <0)             // || = veya işareti
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");     // SWITCH CASE İLE
            //        break;
            //    case 30:
            //        Console.WriteLine("Number is 30");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20 or 30");
            //        break;
            //}



            //if (number==10) 
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number==20)
            //{
            //    Console.WriteLine("Number is 20");                  //ELSE İF İLE 
            //}
            //else 
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}
            //Console.ReadLine();
        }
    }
}
