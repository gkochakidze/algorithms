// https://codeforces.com/problemset/problem/835/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class KeyRaces
    {
        public void Solve()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            var firstPlayerTime = array[1] * array[0] + 2 * array[3];
            var secondPlayerTime = array[2] * array[0] + 2 * array[4];
            if (firstPlayerTime < secondPlayerTime)
                Console.WriteLine("First");
            else if (firstPlayerTime > secondPlayerTime)
                Console.WriteLine("Second");
            else
                Console.WriteLine("Friendship");
        }
    }
}
