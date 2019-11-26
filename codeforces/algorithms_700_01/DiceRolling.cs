// https://codeforces.com/problemset/problem/1093/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class DiceRolling
    {
        public void Solve()
        {
            var queriesAmount = int.Parse(Console.ReadLine());
            var queries = Enumerable.Range(1, queriesAmount).Select(x => int.Parse(Console.ReadLine()) / 2);
            Console.WriteLine(string.Join("\n", queries));
        }
    }
}
