// https://codeforces.com/problemset/problem/1154/A
using System;
using System.Linq;

namespace Algorithms
{
    public class RestoringThreeNumbers
    {
        public void ParseSolveWrite()
        {
            var sums = Parse();
            var (a, b, c) = Solve(sums);
            Write(a, b, c);
        }

        private int[] Parse()
        {
            var input = Console.ReadLine();
            var array = input
                .Split(new char[] { ' ' })
                .Select((value) => int.Parse(value))
                .ToArray();
            return array;
        }

        private (int, int, int) Solve(int[] sums)
        {
            Array.Sort(sums);
            var a = sums[3] - sums[2];
            var b = sums[3] - sums[1];
            var c = sums[3] - sums[0];
            return (a, b, c);
        }

        private void Write(int a, int b, int c)
        {
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
