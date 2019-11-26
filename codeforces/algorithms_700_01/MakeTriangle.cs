// https://codeforces.com/problemset/problem/1064/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class MakeTriangle
    {
        public void Solve()
        {
            var vertices = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x));
            var max = vertices.OrderBy(x => x).LastOrDefault();
            var otherVerticesSum = vertices.Aggregate(0, (sum, x) => sum + x) - max;
            Console.WriteLine((otherVerticesSum > max) ? "0" : "" + (max - otherVerticesSum + 1));
        }
    }
}
