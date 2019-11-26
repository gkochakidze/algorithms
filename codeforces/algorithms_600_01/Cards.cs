// https://codeforces.com/problemset/problem/1220/A
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class Cards
    {
        public void ParseSolveWrite()
        {
            var digitLetters = Parse();
            var binaryNumberText = Solve(digitLetters);
            Write(binaryNumberText);
        }

        private List<string> Parse()
        {
            var numberOfLetters = int.Parse(Console.ReadLine());
            var digitLetters = Enumerable
                .Range(1, numberOfLetters)
                .Select(x => char.ToString((char)Console.Read()))
                .ToList();
            return digitLetters;
        }

        private string Solve(List<string> digitLetters)
        {
            return string.Join(" ", Enumerable.Concat(
                Enumerable.Range(1, digitLetters.Count(x => x == "n")).Select(x => "1"),
                Enumerable.Range(1, digitLetters.Count(x => x == "z")).Select(x => "0")));
        }

        private void Write(string answer)
        {
            Console.WriteLine(answer);
        }
    }
}
