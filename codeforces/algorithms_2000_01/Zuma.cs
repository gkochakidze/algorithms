// https://codeforces.com/problemset/problem/607/B
using System;
using System.Linq;

namespace algorithms_2000_01
{
    public class Zuma
    {
        public void Solve()
        {
            var length = int.Parse(Console.ReadLine());
            var gemstones = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            var memo = new int[length + 1, length + 1];
            for (int i = 0; i < length; i++) memo[i, i] = 1;
            for (int len = 2; len <= length; len++)
            {
                for (int start = 0, end = len - 1; end < length; start++, end++)
                {
                    var minDuration = 1 + memo[start + 1, end];
                    if (gemstones[start] == gemstones[start + 1])
                        minDuration = Math.Min(minDuration, 1 + memo[start + 2, end]);
                    for (int k = start + 2; k <= end; k++)
                        if (gemstones[start] == gemstones[k])
                            minDuration = Math.Min(minDuration, memo[start + 1, k - 1] + memo[k + 1, end]);
                    memo[start, end] = minDuration;
                }
            }
            Console.WriteLine(memo[0, length - 1]);
        }
    }
}
