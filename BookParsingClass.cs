using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BookParsing
{
	public class ParsingProgram
	{

		public static void Main (string[] args)
		{
			
			ParsingProgram program = new ParsingProgram ();

			string filename = "Sample-File.txt";
			string inputString = File.ReadAllText (filename);

			inputString = inputString.ToLower ();
			string inputStringStripped = program.StringStripper(inputString);
			List<string> wordList = program.inputStringSplit (inputStringStripped);
			Dictionary<string, int> wordCount = program.wordCounter (wordList);
			program.WordCountDisplay (wordCount);

		} // end of Main ()


		public string StringStripper(string inputString)
		{
			string[] stripChars = { ";", ",", ".", "-", "_", "^", "(", ")", "[", "]","?", "!", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n", "\t", "\r" };

			foreach (string character in stripChars) {
				inputString = inputString.Replace (character, "");
			}
			return inputString;
		}


		public List<string> inputStringSplit (string inputStr)
		{
			string[] inputStrSplit = inputStr.Split (' ');
			List<string> wordlist = inputStrSplit.ToList ();
			return wordlist;
		}


		public Dictionary<string, int> wordCounter (List<string> wordList)
		{
			Dictionary<string, int> wordCount = new Dictionary<string, int>();

			foreach (string word in wordList) {
				if (wordCount.ContainsKey (word)) {
					wordCount [word]++;
				} 
				else {
					wordCount [word] = 1;
				}
			}
			return wordCount;
		}


		public void WordCountDisplay (Dictionary<string, int> dictionary)
		{
			PrimeCheckerClass primeChecker = new PrimeCheckerClass ();
			Console.WriteLine("Unique Words in the File: ");
			Console.WriteLine();

			int count = 1;
			foreach (KeyValuePair<string, int> pair in dictionary)
			{
				string primeCheck = primeChecker.PrimeNumChecker (pair.Value);
				Console.WriteLine(count + "\t" + pair.Value + " count(s) of the word\t\"" + pair.Key + "\" was found. " + "\n\t\"" + pair.Value + "\" is " + primeCheck + " number.\n");
				count++;
			}
		}
			
	}
}

