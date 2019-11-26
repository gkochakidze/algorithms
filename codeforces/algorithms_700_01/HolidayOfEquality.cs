// https://codeforces.com/problemset/problem/758/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class HolidayOfEquality
    {
        public void Solve()
        {
            var populationAmount = int.Parse(Console.ReadLine());
            var populationProperties = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x));
            var propertySum = populationProperties.Aggregate(0, (sum, x) => sum + x);
            var maxProperty = populationProperties.Aggregate(0, (max, x) => Math.Max(max, x));
            Console.WriteLine(maxProperty * populationAmount - propertySum);
        }
    }
}
