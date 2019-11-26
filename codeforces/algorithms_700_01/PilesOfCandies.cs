// https://codeforces.com/problemset/problem/1196/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class PilesOfCandies
    {
        public void Solve()
        {
            var queriesAmount = int.Parse(Console.ReadLine());
            var queriesAnswer = Enumerable
                .Range(1, queriesAmount)
                .Select(x => Console.ReadLine())
                .Select(x => x.Split(new char[] { ' ' }))
                .Select(x => x.Select(y => long.Parse(y)))
                .Select(x => x.Aggregate(0, (long sum, long y) => sum + y) / 2)
                .Aggregate("", (answer, x) => answer + x + "\n");
            Console.WriteLine(queriesAnswer);
        }
    }
}
