// https://codeforces.com/problemset/problem/1146/A
using System;
using System.Linq;

namespace Algorithms
{
    public class LoveA
    {
        public void ParseSolveWrite()
        {
            var wordToMeasure = Parse();
            var lengthOfModifiedWord = Solve(wordToMeasure);
            Write(lengthOfModifiedWord);
        }

        private string Parse()
        {
            return Console.ReadLine();
        }

        private int Solve(string wordToMeasure)
        {
            int numberOfCharacterA = wordToMeasure.Count(x => x == 'a');
            return Math.Min(2 * numberOfCharacterA - 1, wordToMeasure.Length);
        }

        private void Write(int lengthOfModifiedWord)
        {
            Console.WriteLine(lengthOfModifiedWord);
        }
    }
}
