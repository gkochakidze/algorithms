// https://codeforces.com/problemset/problem/977/A
using System;

namespace Algorithms
{
    public class WrongSubtraction
    {
        public void ParseSolveWrite()
        {
            var (n, k) = Parse();
            var result = Solve(n, k);
            Write(result);
        }

        private (int, int) Parse()
        {
            var input = Console.ReadLine();
            var array = input.Split(new char[1] { ' ' });
            var n = int.Parse(array[0]);
            var k = int.Parse(array[1]);
            return (n, k);
        }

        private int Solve(int n, int k)
        {
            for (int i = 0; i < k; i++)
                n = n % 10 == 0 ? n / 10 : n - 1;
            return n;
        }

        private void Write(int result)
        {
            Console.WriteLine(result);
        }
    }
}
