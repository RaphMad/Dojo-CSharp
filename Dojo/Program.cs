namespace Dojo
{
   using System;
   using System.Linq;

   class Program
   {
      static void Main()
      {
         var dojo = new Dojo();
         var primes = dojo.Primes().Take(5);

         Console.WriteLine(primes.Aggregate("", (text, prime) => text + ", " + prime).TrimStart(',', ' '));
         Console.ReadKey();
      }
   }
}
