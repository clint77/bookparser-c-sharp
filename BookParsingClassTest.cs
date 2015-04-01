using NUnit.Framework;
using System.Collections.Generic;
using System;


namespace BookParsing
{
	[TestFixture]
	public class ParsingProgramTest
	{
		
		[Test]
		public void StringStripperShouldLeaveOnlyWords()
		{
			ParsingProgram program = new ParsingProgram ();
			string inputString = "Bananas?, the monkey ask.";
		    string inputStringStripped = program.StringStripper(inputString);
			Assert.AreEqual("Bananas the monkey ask", inputStringStripped);
		}

		[Test]
		public void wordCounterShouldReturnCorrectWordCount()
		{
			ParsingProgram program = new ParsingProgram ();
			List<string> sampleList = new List<string>(new string[] {"bananas", "monkey", "bananas"});
			Dictionary<string, int> wordCount = program.wordCounter(sampleList);
			Assert.AreEqual(2, wordCount["bananas"]);
			Assert.AreEqual(1, wordCount["monkey"]);
		}
			
	}
}

