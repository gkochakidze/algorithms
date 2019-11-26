// https://codeforces.com/problemset/problem/617/A
using System;

namespace algorithms_700_01
{
    public class ElephantAndFriend
    {
        public void Solve()
        {
            var frientPosition = int.Parse(Console.ReadLine());
            Console.WriteLine(frientPosition / 5 + (frientPosition % 5 == 0 ? 0 : 1));
        }
    }
}
