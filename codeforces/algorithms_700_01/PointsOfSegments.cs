// https://codeforces.com/problemset/problem/1015/A
using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithms_700_01
{
    public class PointsOfSegments
    {
        public void Solve()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            var segmentsCount = array[0];
            var coordinatesUpperBound = array[1];
            var coordinates = new int[coordinatesUpperBound];
            for (int i = 0; i < segmentsCount; i++)
            {
                array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                for (int j = array[0]; j <= array[1]; j++)
                    coordinates[j - 1]++;
            }
            var unmarkedCoordinates = new List<int>();
            for (int i = 0; i < coordinates.Length; i++)
                if (coordinates[i] == 0)
                    unmarkedCoordinates.Add(i + 1);
            Console.WriteLine(unmarkedCoordinates.Count());
            Console.WriteLine(string.Join(" ", unmarkedCoordinates));
        }
    }
}
