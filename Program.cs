using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i = i + 1)
            {
               int mod3 = i % 3; // same as i divided by 3 but give me just the numbers after the decimal, % means modulus
               int mod5 = i % 5;

               if ( mod3 == 0 && mod5 == 0 )
               {
                  Console.WriteLine("FizzBuzz");
               }
               else if ( mod3 == 0 )  // When there ir no remainder (ie. 9/3 = 3.0 ) there is a zero after the decimal, so print Fizz. 
               {
                  Console.WriteLine("Fizz");    
               }
               else if ( mod5 == 0 )
               {
                  Console.WriteLine("Buzz");
               }
               else
               {
                  Console.WriteLine(i);
               }
            }
        }
    }
}
