// https://codeforces.com/problemset/problem/734/A
using System;
using System.Collections.Generic;

namespace algorithms_700_01
{
    public class AntonAndDanik
    {
        public void ParseSolveWrite()
        {
            var winnersOccurrence = Parse();
            var winner = Solve(winnersOccurrence);
            Write(winner);
        }

        private void Write(string winner)
        {
            Console.WriteLine(winner);
        }

        private string Solve(List<string> winnersOccurrence)
        {
            int antonWins = 0, danikWins = 0;
            foreach (var winner in winnersOccurrence)
            {
                if (winner == "A") antonWins++;
                if (winner == "D") danikWins++;
            }
            return antonWins > danikWins ? "Anton" : antonWins == danikWins ? "Friendship" : "Danik";
        }

        private List<string> Parse()
        {
            var winnersOccurrence = new List<string>();
            var numberOfGames = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfGames; i++)
                winnersOccurrence.Add("" + (char)Console.Read());
            return winnersOccurrence;
        }
    }
}
