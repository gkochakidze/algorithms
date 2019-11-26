// https://codeforces.com/problemset/problem/1077/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class FrogJumping
    {
        public void Solve()
        {
            var queriesAmount = int.Parse(Console.ReadLine());
            var queriesAnswer = Enumerable
                .Range(1, queriesAmount)
                .Select(x => Console.ReadLine())
                .Select(x => x.Split(new char[] { ' ' }))
                .Select(x => x.Select(y => long.Parse(y)).ToArray())
                .Select(x => (x[0] * (x[2] / 2 + x[2] % 2)) - (x[1] * (x[2] / 2)))
                .Aggregate("", (answer, x) => answer + x + "\n");
            Console.WriteLine(queriesAnswer);
        }
    }
}
