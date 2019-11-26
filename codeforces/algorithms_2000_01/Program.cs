// https://codeforces.com/problemset/page/27?order=BY_RATING_DESC
using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithms_2000_01
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x));
            var n = array.First();
            var m = array.Last();
            var dp = new int[m + 1];
            for (int i = 1; i <= n; i++)
            {
                var j = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).First();
                for (int k = j; k >= 1; k--)
                    dp[j] = Math.Max(dp[j], dp[k] + 1);
            }
            var longestSubsequence = dp.Aggregate(0, Math.Max);
            Console.WriteLine(n - longestSubsequence);
        }
    }
}
