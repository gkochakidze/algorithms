// https://codeforces.com/contest/749/problem/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class BachgoldProblem
    {
        public void Solve()
        {
            var number = int.Parse(Console.ReadLine());
            var primeNumbersRepresentation = Enumerable.Range(1, number / 2).Select(x => 2).ToList();
            if (number % 2 == 1) primeNumbersRepresentation[primeNumbersRepresentation.Count - 1] = 3;
            Console.WriteLine(primeNumbersRepresentation.Count);
            Console.WriteLine(string.Join(" ", primeNumbersRepresentation));
        }
    }
}
