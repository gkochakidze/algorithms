// https://codeforces.com/problemset/problem/1139/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class EvenSubstrings
    {
        public void Solve()
        {
            Console.ReadLine();
            var substringsCount = Console.ReadLine()
                .Select((x, index) => (value: int.Parse("" + x), index))
                .Aggregate(0, (sum, pair) => sum + (pair.value % 2 == 0 ? pair.index + 1 : 0));
            Console.WriteLine(substringsCount);
        }
    }
}
