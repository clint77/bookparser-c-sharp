using NUnit.Framework;
using System;

namespace BookParsing
{
	[TestFixture]
	public class PrimeCheckerClassTest
	{
		[Test]
		public void PrimeNumCheckerWillSayAPrimeIfNumberIsPrimeNumber()
		{
			PrimeCheckerClass obj = new PrimeCheckerClass ();
			int numberPrime = 5;
			string PrimeCheck = obj.PrimeNumChecker (numberPrime);
			PrimeCheck = obj.PrimeNumChecker (numberPrime);
			Assert.AreEqual ("a prime", PrimeCheck);
		}

		[Test]
		public void PrimeNumCheckerWillSayNotAPrimeIfNumberIsNotAPrimeNumber()
		{
			PrimeCheckerClass obj = new PrimeCheckerClass ();
			int numberNotPrime = 12;
			string PrimeCheck = obj.PrimeNumChecker (numberNotPrime);
			Assert.AreEqual ("not a prime", PrimeCheck);
		}

	}
}