// https://codeforces.com/problemset/problem/1191/A
using System;

namespace algorithms_700_01
{
    public class TokitsukazeEnhancement
    {
        public void Solve()
        {
            var healthPoints = int.Parse(Console.ReadLine());
            if (healthPoints % 4 == 1)
                Console.WriteLine("0 A");
            else if (healthPoints % 4 == 2)
                Console.WriteLine("1 B");
            else if (healthPoints % 4 == 3)
                Console.WriteLine("2 A");
            else if (healthPoints % 4 == 0)
                Console.WriteLine("1 A");
        }
    }
}
