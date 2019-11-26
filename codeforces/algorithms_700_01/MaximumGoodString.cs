// https://codeforces.com/problemset/problem/1148/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class MaximumGoodString
    {
        public void Solve()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => long.Parse(x)).ToArray();
            var maxStringLength = 2 * array[2] + 2 * Math.Min(array[0], array[1]) + (array[0] == array[1] ? 0 : 1);
            Console.WriteLine(maxStringLength);
        }
    }
}
