// https://codeforces.com/problemset/problem/1005/A
using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithms_700_01
{
    public class TanyaAndStairways
    {
        public void Solve()
        {
            Console.ReadLine();
            var climbedStairs = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(x => int.Parse(x))
                .Aggregate(
                    new List<int>(), (list, x) =>
                    {
                        if (x == 1)
                            list.Add(1);
                        else
                            list[list.Count - 1] = list.Last() + 1;
                        return list;
                    }
                );
            Console.WriteLine(climbedStairs.Count());
            Console.WriteLine(string.Join(" ", climbedStairs));
        }
    }
}
