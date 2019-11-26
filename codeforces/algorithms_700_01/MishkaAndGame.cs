// https://codeforces.com/problemset/problem/703/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class MishkaAndGame
    {
        public void Solve()
        {
            var gamesCount = int.Parse(Console.ReadLine());
            var scoreDiff = Enumerable
                .Range(1, gamesCount)
                .Select(x => Console.ReadLine())
                .Select(x => x.Split(new char[] { ' ' }))
                .Select(x => x.Select(y => int.Parse(y)).ToArray())
                .Select(x => x[0] > x[1] ? 1 : x[0] == x[1] ? 0 : -1)
                .Aggregate(0, (diff, outcome) => diff + outcome);
            Console.WriteLine(scoreDiff == 0 ? "Friendship is magic!^^" : scoreDiff > 0 ? "Mishka" : "Chris");
        }
    }
}
