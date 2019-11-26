// https://codeforces.com/problemset/problem/1017/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class FrankRank
    {
        public void Solve()
        {
            var studentsCount = int.Parse(Console.ReadLine());
            var frankPoints = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).Aggregate(0, (sum, x) => sum + x);
            var frankRank = 1;
            for (int i = 1; i < studentsCount; i++)
            {
                var pointsSum = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).Aggregate(0, (sum, x) => sum + x);
                if (pointsSum > frankPoints)
                    frankRank++;
            }
            Console.WriteLine(frankRank);
        }
    }
}
