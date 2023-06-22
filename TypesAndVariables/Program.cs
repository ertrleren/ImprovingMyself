using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            int number1 = 654454534;
            long number2 = 925647389273647128;  
            short number3 = 32767;
            byte number4 = 255;
            bool condition = false;
            char MyChar = 'A';
            double Numbers = 10.5;
            decimal Numbers5 = 10.43333333m;
            var numbers7 = 61;
            numbers7 = 'A';
            
            
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Durum is {0}", condition);
            Console.WriteLine("Karakter is {0}", MyChar);
            Console.WriteLine("Number5 is {0}", Numbers);
            Console.WriteLine("Number6 is {0}", Numbers5);
            Console.WriteLine(numbers7); 
           
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Sunday,Tuesday,Wednesday,Thursday,Friday,Saturday
    }
}
