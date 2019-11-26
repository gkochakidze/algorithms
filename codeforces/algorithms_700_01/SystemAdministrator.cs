// https://codeforces.com/problemset/problem/245/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class SystemAdministrator
    {
        public void Solve()
        {
            var testCases = int.Parse(Console.ReadLine());
            var servers = new int[2];
            for (int i = 0; i < testCases; i++)
            {
                var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                var serverIndex = array[0] - 1;
                var successPingCount = array[1];
                var failPingCount = array[2];
                servers[serverIndex] += successPingCount - failPingCount;
            }
            for (int i = 0; i < servers.Length; i++)
                Console.WriteLine((servers[i] >= 0) ? "LIVE" : "DEAD");
        }
    }
}
