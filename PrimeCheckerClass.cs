using System;

namespace BookParsing
{
	public class PrimeCheckerClass
	{
		private static string PrimeOrNotPrime (int number)
		{
			string primeOrNot = "a prime";
			for (int i = 2; i < number; i++) 
			{
				if (number % i == 0) {
					primeOrNot = "not a prime";
				} 
			}
			return primeOrNot;
		}

		public string PrimeNumChecker (int number)
		{
			return PrimeOrNotPrime (number);
		}
		
	}
}

