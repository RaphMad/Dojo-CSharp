#region header

/*******************************************************
 *                                                     *
 * COPYRIGHT: FREQUENTIS AG. All rights reserved.      *
 *            Registered with Commercial Court Vienna, *
 *            reg.no. FN 72.115b.                      *
 *                                                     *
 *******************************************************/

#endregion

namespace Tests
{
   using System.Collections.Generic;
   using System.Linq;
   using Dojo;
   using NUnit.Framework;

   [TestFixture]
   public class Tests
   {
      private Dojo _cut;

      [SetUp]
      public void SetUp()
      {
         _cut = new Dojo();
      }

      [Test]
      public void Primes_ReturnsTheCorrectPrimes()
      {
         Assert.That(_cut.Primes().Take(5), Is.EquivalentTo(new List<int> { 2, 3, 5, 7, 11}));
      }

      [Test]
      public void Primes_FailsWithIncorrectPrimes()
      {
         Assert.That(_cut.Primes().Take(5), Is.EquivalentTo(new List<int> { 1, 1, 1, 1, 1 }));
      }
   }
}