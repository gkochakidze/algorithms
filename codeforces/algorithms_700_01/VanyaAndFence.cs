// https://codeforces.com/problemset/problem/677/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class VanyaAndFence
    {
        public void Solve()
        {
            var firstLine = Console.ReadLine();
            var numberOfPersons = int.Parse(firstLine.Split(new char[] { ' ' })[0]);
            var fenceOfHeight = int.Parse(firstLine.Split(new char[] { ' ' })[1]);
            var secondLine = Console.ReadLine();
            var heightsOfPersons = secondLine.Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            var minWidthOfRoad = heightsOfPersons.Aggregate(0, (acc, x) => acc + (x > fenceOfHeight ? 2 : 1));
            Console.WriteLine(minWidthOfRoad);
        }

    }
}
