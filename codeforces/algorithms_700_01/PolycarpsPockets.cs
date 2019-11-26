// https://codeforces.com/problemset/problem/1003/A
using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithms_700_01
{
    public class PolycarpsPockets
    {
        public void Solve()
        {
            Console.ReadLine();
            var pocketAmount = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(x => int.Parse(x))
                .Aggregate(
                    new Dictionary<int, int>(),
                    (dict, x) =>
                    {
                        if (!dict.ContainsKey(x))
                            dict.Add(x, 0);
                        dict[x] = dict[x] + 1;
                        return dict;
                    }
                )
                .Aggregate(0, (maxOccurrance, pair) => Math.Max(maxOccurrance, pair.Value));
            Console.WriteLine(pocketAmount);
        }
    }
}
