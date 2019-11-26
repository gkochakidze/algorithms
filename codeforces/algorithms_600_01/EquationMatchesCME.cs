// https://codeforces.com/problemset/problem/1223/A
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class EquationMatchesCME
    {
        public void ParseSolveWrite()
        {
            var matchQueries = Parse();
            var matchAnswers = Solve(matchQueries);
            Write(matchAnswers);
        }

        private List<int> Parse()
        {
            var numberOfQueries = int.Parse(Console.ReadLine());
            var matchQueries = new List<int>();
            for (int i = 0; i < numberOfQueries; i++)
                matchQueries.Add(int.Parse(Console.ReadLine()));
            return matchQueries;
        }

        private List<int> Solve(List<int> matchQueries)
        {
            return matchQueries.Select(matchQuery => matchQuery > 2 ? matchQuery % 2 : 2).ToList();
        }

        private void Write(List<int> matchAnswers)
        {
            foreach (var matchAnswer in matchAnswers)
                Console.WriteLine(matchAnswer);
        }
    }
}
