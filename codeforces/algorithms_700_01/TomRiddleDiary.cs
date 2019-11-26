// https://codeforces.com/problemset/problem/855/A
using System;
using System.Collections.Generic;

namespace algorithms_700_01
{
    public class TomRiddleDiary
    {
        public void Solve()
        {
            var testCases = int.Parse(Console.ReadLine());
            var namesOccurrance = new HashSet<string>();
            for (int i = 0; i < testCases; i++)
            {
                var name = Console.ReadLine();
                if (namesOccurrance.Contains(name))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                    namesOccurrance.Add(name);
                }
            }
        }
    }
}
