// https://codeforces.com/problemset/problem/1143/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class Doors
    {
        public void Solve()
        {
            Console.ReadLine();
            var doors = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            for (int i = doors.Length - 1; i > 0; i--)
            {
                if (doors[i] != doors[i - 1])
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
