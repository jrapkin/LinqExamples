using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExampleQuestions
{
	class Problem1
	{

		List<string> words;
		List<string> grades;

		public void FindCharactersInString()
		{
			words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
			var wordsThatContain = words.Where(words => words.Contains("th"));
		}
		public void ReturnDistinctList()
		{
			words = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
			var wordsThatContain = words.Distinct();
		}
		public void ReturnCalculatedClassAverage()
		{
			grades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
			var classAverage = grades.Select(studentGrades => studentGrades.Split(',').Select(convertedGrades => Convert.ToDouble(convertedGrades))).Select(studentGrades => studentGrades.Where(convertedGrades => convertedGrades != studentGrades.Min())).Select(gradesToBeAveraged => gradesToBeAveraged.Average()).Average();

		}

		public Dictionary<char, string> CompressedAndOrderedString(string word)
		{
			
			var compressedString = word.ToLower().OrderBy(numberOfCharacters => numberOfCharacters).GroupBy(letter => letter).ToDictionary(grp => grp.Key, grp => grp.Count().ToString());
			return compressedString;

			
		}
	}
}

	

