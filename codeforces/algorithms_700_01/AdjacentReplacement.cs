// https://codeforces.com/problemset/problem/1006/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class AdjacentReplacement
    {
        public void Solve()
        {
            Console.ReadLine();
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(x => int.Parse(x))
                .Select(x => x % 2 == 0 ? x - 1 : x)));
        }
    }
}
