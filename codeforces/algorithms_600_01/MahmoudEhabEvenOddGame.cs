// https://codeforces.com/problemset/problem/959/A
using System;

namespace Algorithms
{
    public class MahmoudEhabEvenOddGame
    {
        public void ParseSolveWrite()
        {
            var favoriteInteger = Parse();
            var winner = Solve(favoriteInteger);
            Write(winner);
        }

        private int Parse()
        {
            int favoriteInteger = int.Parse(Console.ReadLine());
            return favoriteInteger;
        }

        private string Solve(int favoriteInteger)
        {
            return favoriteInteger % 2 == 0 ? "Mahmoud" : "Ehab";
        }

        private void Write(string allWaysToDivideTeam)
        {
            Console.WriteLine(allWaysToDivideTeam);
        }
    }
}
