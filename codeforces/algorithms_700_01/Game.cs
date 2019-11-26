// https://codeforces.com/problemset/problem/984/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class Game
    {
        public void Solve()
        {
            Console.ReadLine();
            var array = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(x => int.Parse(x))
                .OrderBy(x => x)
                .ToArray();
            Console.WriteLine(array[(array.Length - 1) / 2]);
        }
    }
}
