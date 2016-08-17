#region header

/*******************************************************
 *                                                     *
 * COPYRIGHT: FREQUENTIS AG. All rights reserved.      *
 *            Registered with Commercial Court Vienna, *
 *            reg.no. FN 72.115b.                      *
 *                                                     *
 *******************************************************/

#endregion

namespace Dojo
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class Dojo
   {
      public IEnumerable<int> Primes()
      {
         return Range(2).Where(candidate => Range(2, (int)Math.Sqrt(candidate))
                                               .All(divisor => candidate % divisor != 0));
      }

      private static IEnumerable<int> Range(int from, int to = int.MaxValue)
      {
         for (int i = from; i <= to; i++) yield return i;
      }
   }
}
