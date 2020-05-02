using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

             int k = 0;

             Console.WriteLine(" Eded daxil edin: ");
             decimal number;
             Decimal.TryParse(Console.ReadLine(), out number);

             while(number>=1)
             {  
                 number = number/10;
                 k++;
             }

             Console.WriteLine($"Daxil etdiyiniz eded {k} reqemlidir"); 



            // Number is prime or not
              int m = 0;

             Console.WriteLine(" Eded daxil edin: ");
             int a;
             Int32.TryParse(Console.ReadLine(), out a);

             for (int i = 2;  i*i <= a ; i++)
             {
                 if (a % i == 0){
                     m++;
                 }
             }

             if (m > 0)
             {
                 Console.WriteLine("Daxil etdiyiniz eded murekkebdir");
             }

             else
             {
                 Console.WriteLine("Daxil etdiyiniz eded sadedir");
             }



            // which month


            Console.WriteLine("Hansi fesilde oldugunuzu bilmek uchun cari ayin nomresini daxil edin: ");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 12 || n==1 || n==2 )
            {
                Console.WriteLine("QISH FESLIDIR");
            }
            else if (n>=3 && n<=5)
            {
                Console.WriteLine("YAZ FESLIDIR");
            }
            else if (n >= 6 && n <= 8)
            {
                Console.WriteLine("YAY FESLIDIR");
            }
            else if (n >= 9 && n <= 11)
            {
                Console.WriteLine("PAYIZ FESLIDIR");
            }

            else
            {
                Console.WriteLine("BIR ILDE 12 AY VAR");
            }
        }
    }

}
