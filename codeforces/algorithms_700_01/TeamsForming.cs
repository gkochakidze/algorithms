// https://codeforces.com/problemset/problem/1092/B
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class TeamsForming
    {
        public void Solve()
        {
            Console.ReadLine();
            var array = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(x => int.Parse(x))
                .OrderBy(x => x)
                .ToArray();
            var diffsSum = 0;
            for (int i = 0; i < array.Length; i += 2)
                diffsSum += array[i + 1] - array[i];
            Console.WriteLine(diffsSum);

        }
    }
}
