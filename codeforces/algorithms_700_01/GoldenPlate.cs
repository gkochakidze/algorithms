// https://codeforces.com/problemset/problem/1031/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class GoldenPlate
    {
        public void Solve()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            var height = array[0];
            var width = array[1];
            var rings = array[2];
            var ringedCells = 0;
            for (int i = 0; i < rings; i++)
            {
                var outerSquareSpace = (width - 4 * i) * (height - 4 * i);
                var innerSquareSpace = (width - 4 * i - 2) * (height - 4 * i - 2);
                ringedCells += outerSquareSpace - innerSquareSpace;
            }
            Console.WriteLine(ringedCells);
        }
    }
}
