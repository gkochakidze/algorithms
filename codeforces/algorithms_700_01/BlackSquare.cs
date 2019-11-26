// https://codeforces.com/problemset/problem/431/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class BlackSquare
    {
        public void Solve()
        {
            var screenSquareCalories = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            var screenSquareOccurrences = Console.ReadLine().Select(x => int.Parse("" + x));
            var spentCalories = screenSquareOccurrences.Select(x => screenSquareCalories[x - 1]).Aggregate(0, (sum, value) => sum + value);
            Console.WriteLine(spentCalories);
        }
    }
}
