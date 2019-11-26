// https://codeforces.com/problemset/problem/177/A2
// https://codeforces.com/problemset/problem/177/A1
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class GoodMatrixElements
    {
        public void Solve()
        {
            var squareLength = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < squareLength; i++)
            {
                var row = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < squareLength; j++)
                {
                    if (i == j || i + j == squareLength - 1 || i == squareLength / 2 || j == squareLength / 2)
                        sum += row[j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
