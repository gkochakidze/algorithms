// https://codeforces.com/problemset/problem/1257/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class RivalStudents
    {
        public void Solve()
        {
            var testCasesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCasesCount; i++)
            {
                var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                var maxDifference = Math.Min(Math.Abs(array[2] - array[3]) + array[1], array[0] - 1);
                Console.WriteLine(maxDifference);
            }

        }
    }
}
