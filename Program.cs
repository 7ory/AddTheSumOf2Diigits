using System;

namespace AddingTheSumOf2Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 29;

            Console.WriteLine("You sum is: "+ AddtwoDigits(n));
            Console.ReadKey();
          

            static decimal AddtwoDigits(int n)
            {
               
                decimal sum = 0;
                decimal remainder = 0;

                while (n > 0)
                {
                    remainder = n % 10; // we're splitting 2 and 9 
                    sum += remainder ; // storing each remainer on top of the other
                    n = n / 10;       // Now were want the number the ramainder to be assigned to n.
                }
               
                return sum;
            }

          
        }
    }
}
