// https://codeforces.com/problemset/problem/803/B

using System;
using System.Linq;

namespace algorithms_1200_01
{
    public class DistancesToZero
    {
        public void Solve()
        {
            var length = int.Parse(Console.ReadLine());
            var distances = new int[length].Select(x => int.MaxValue).ToArray();
            var digits = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            int startZeroPosition = -1, endZeroPosition = -1;
            for (int start = 0, end = length - 1; start < length; start++, end--)
            {
                startZeroPosition = (digits[start] == 0) ? start : startZeroPosition;
                endZeroPosition = (digits[end] == 0) ? end : endZeroPosition;
                if (startZeroPosition != -1)
                    distances[start] = Math.Min(distances[start], Math.Abs(startZeroPosition - start));
                if (endZeroPosition != -1)
                    distances[end] = Math.Min(distances[end], Math.Abs(endZeroPosition - end));
            }
            Console.WriteLine(string.Join(" ", distances));
        }
    }
}
