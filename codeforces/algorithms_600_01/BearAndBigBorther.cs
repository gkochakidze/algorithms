// https://codeforces.com/problemset/problem/791/A
using System;

namespace Algorithms
{
    public class BearAndBigBorther
    {
        public void ParseSolveWrite()
        {
            var (limakAge, bobAge) = Parse();
            var result = Solve(limakAge, bobAge);
            Write(result);
        }

        private (int, int) Parse()
        {
            var input = Console.ReadLine();
            var limakAge = int.Parse(input.Split(new char[] { ' ' })[0]);
            var bobAge = int.Parse(input.Split(new char[] { ' ' })[1]);
            return (limakAge, bobAge);
        }

        private int Solve(int limakAge, int bobAge)
        {
            int years;
            for (years = 1; limakAge <= bobAge; years++)
            {
                limakAge = 3 * limakAge;
                bobAge = 2 * bobAge;
            }
            return years - 1;
        }

        private void Write(int result)
        {
            Console.WriteLine(result);
        }
    }
}
