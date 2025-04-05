using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace _19252_C_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//Variables to hold indexes of occurances 
		List<int> matchedIndexes;
		int currentIndex; // for highlighting with different color

		//-------------------------------------- HIGHLIGHTING RESULTS BEAUTY -------------------------------------------------------------------------------
		#region BEAUTIFY_OCCURRENCES
		//Just for GUI beauty
		private void ClearHighlights(RichTextBox richTextBox)// Not using it
		{
			richTextBox.SelectAll();
			richTextBox.SelectionBackColor = Color.White;
			richTextBox.SelectionLength = 0;
		}
		private void HighlightOccurrences(RichTextBox richTextBox, List<int> indexes, int patternLength, Color highlightColor)
		{ 
			foreach (int index in indexes)
			{
				richTextBox.Select(index, patternLength);
				richTextBox.SelectionBackColor = highlightColor;
			}

			richTextBox.SelectionLength = 0;
		}
		private void HighlightCurrentOccurrence(RichTextBox richTextBox, int index, int patternLength, Color currentColor)
		{
			HighlightOccurrences(richTextBox, matchedIndexes, patternLength, Color.AliceBlue);

			richTextBox.Select(index, patternLength);
			richTextBox.SelectionBackColor = currentColor;
			richTextBox.SelectionLength = 0; 

			richTextBox.ScrollToCaret();
		}
		private void HighlightingWords() {
			HighlightOccurrences(fileText, matchedIndexes, patternTxtBox.Text.Length, Color.AliceBlue);
			if (matchedIndexes.Count > 0)
			{
				currentIndex = 0;
				HighlightCurrentOccurrence(fileText, matchedIndexes[currentIndex], patternTxtBox.Text.Length, Color.Orange);
			}
		}
		#endregion


		//--------------------------------------- ALGORITHMS -------------------------------------------------------------------------------------------------
		public  List<int> RabinKarpAlg(string text, string pattern)//Rabin-Karp algorithm
		{
			// Start searching and start timer
			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();

			// List of starting indexes of matched patterns
			List<int> matchedPatternsStartingIndexes = new List<int>();

			// Lengths of text and pattern
			int textLength = text.Length;
			int patternLength = pattern.Length;

			// Prime and modulus for hashing
			int prime = 31;
			long modulus = 1000000009;

			// Powers for hashing polinoms
			long[] powers = new long[textLength];
			powers[0] = 1;
			for (int i = 1; i < textLength; i++)
			{
				powers[i] = (powers[i - 1] * prime) % modulus;
			}

			// Hashing the text
			long[] hashedText = new long[textLength + 1];
			for (int i = 0; i < textLength; i++)
			{
				hashedText[i + 1] = (hashedText[i] + text[i] * powers[i]) % modulus;
			}

			// Hashing pattern
			long hashedPattern = 0;
			for (int i = 0; i < patternLength; i++)
				hashedPattern = (hashedPattern + pattern[i] * powers[i]) % modulus;

			// Slide the pattern over the text
			for (int i = 0; i + patternLength - 1 < textLength; i++)
			{
				long currentHash = (hashedText[i + patternLength] + modulus - hashedText[i]) % modulus;
				if (currentHash == hashedPattern * powers[i] % modulus)
					matchedPatternsStartingIndexes.Add(i);
			}

			// Show time result
			stopWatch.Stop();
			timeLabel.Text = stopWatch.Elapsed.TotalMilliseconds.ToString() + " ms";

			return matchedPatternsStartingIndexes;
		}

		public string SoundExHash(string word) {

			if (string.IsNullOrEmpty(word))
				return "0000";

			//All characters Upper
			word = word.ToUpper();
			string hashedValue = "" + word[0];

			// Transforming letters to numbers
			Dictionary<char, char> lettersToNumbers = new Dictionary<char, char>{
			{ 'B', '1' }, { 'F', '1' }, { 'P', '1' }, { 'V', '1' },
			{ 'C', '2' }, { 'G', '2' }, { 'J', '2' }, { 'K', '2' },
			{ 'Q', '2' }, { 'S', '2' }, { 'X', '2' }, { 'Z', '2' },
			{ 'D', '3' }, { 'T', '3' },
			{ 'L', '4' },
			{ 'M', '5' }, { 'N', '5' },
			{ 'R', '6' },
			{ 'A', '#' }, { 'E', '#' }, { 'I', '#' }, { 'O', '#' },
			{ 'U', '#' }, { 'H', '#' }, { 'W', '#' }, { 'Y', '#' }};

			char lastDigit = hashedValue[0];

			for (int i = 1; i < word.Length; i++)
			{
				if (lettersToNumbers.TryGetValue(word[i], out char number))
				{
					if (number != '#' && number != lastDigit)
					{
						hashedValue += number;
						lastDigit = number;
					}
				}
			}

			// Making hashedValue to have length of 4 exactly
			return hashedValue.Length < 4 ? hashedValue.PadRight(4, '0') : hashedValue.Substring(0, 4);
		}
		public List<int> SoundExAlg(string text, string pattern)//SoundEx algorithm 
		{
			// Start search and timer
			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();

			// Store indexes of words that sound like pattern
			List<int> matchedPatternsStartingIndexes = new List<int>();

			// Hash pattern
			string patternHashed = SoundExHash(pattern);

			// Regex pattern to exctract only words
			string wordPattern = @"\b\w+\b";

			foreach (Match match in Regex.Matches(text, wordPattern))
			{
				string word = match.Value;
				int startIndex = match.Index;

				if (!string.Equals(word, pattern, StringComparison.OrdinalIgnoreCase) && SoundExHash(word) == patternHashed)
					matchedPatternsStartingIndexes.Add(startIndex);
			}

			// Stop timer and show result
			stopWatch.Stop();
			timeLabel.Text = stopWatch.Elapsed.TotalMilliseconds + " ms";

			return matchedPatternsStartingIndexes;
		}
		//--------------------------------------- BUTTONS --------------------------------------------------------------------------------
		#region BUTTONS
		private void findBtn_Click(object sender, EventArgs e)//Start finding patterns btn
		{
			// Take users input of algorithm
			string algorithmChoice = algorithmCombo.SelectedItem.ToString();

			// Search with Rabin-Karp algorithm
			if (algorithmChoice == algorithmCombo.Items[0].ToString())
			{
				//Find indexes of matched words
				matchedIndexes = RabinKarpAlg(fileText.Text, patternTxtBox.Text);
				occurancesNumber.Text = matchedIndexes.Count.ToString();

				// Highlight all occurrences
				HighlightingWords();
			}
			//Search with SoundEx
			else if (algorithmChoice == algorithmCombo.Items[1].ToString()) {

				//Find indexes of similar spoken words
				matchedIndexes = SoundExAlg(fileText.Text, patternTxtBox.Text);
				occurancesNumber.Text = matchedIndexes.Count.ToString();

				// Highlight all occurrences
				HighlightingWords();
			}
		}
		private void loadFileBtn_Click(object sender, EventArgs e)//Loading file
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog.Title = "Open Text File";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						//Reading file
						string fileContent = File.ReadAllText(openFileDialog.FileName);
      					fileText.Text = fileContent;

						//Showing file name to the user
						fileNameLabel.Text = Path.GetFileName(openFileDialog.FileName);
					}
					catch (Exception ex)
					{	
						MessageBox.Show("Error reading file: " + ex.Message);
					}
				}
			}
		}  
		private void downBtn_Click(object sender, EventArgs e) //Moving occurance down
		{
			if (matchedIndexes == null || matchedIndexes.Count == 0) return;

			if (currentIndex < matchedIndexes.Count - 1)
			{
				currentIndex++;
				// Highlight the new current occurrence
				HighlightCurrentOccurrence(fileText, matchedIndexes[currentIndex], patternTxtBox.Text.Length, Color.Orange);
			}
		}
		private void upBtn_Click(object sender, EventArgs e) //Moving occurance up
		{
			if (matchedIndexes == null || matchedIndexes.Count == 0) return;

			if (currentIndex > 0)
			{
				currentIndex--;

				// Highlight the new current occurrence
				HighlightCurrentOccurrence(fileText, matchedIndexes[currentIndex], patternTxtBox.Text.Length, Color.Orange);
			}
		}
		#endregion

		
	}
}


