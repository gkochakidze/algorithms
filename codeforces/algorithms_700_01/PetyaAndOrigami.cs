// https://codeforces.com/problemset/problem/1080/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class PetyaAndOrigami
    {
        public void Solve()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            var n = array[0];
            var k = array[1];
            var redNotes = (2 * n) / k + ((2 * n) % k == 0 ? 0 : 1);
            var greenNotes = (5 * n) / k + ((5 * n) % k == 0 ? 0 : 1);
            var blueNotes = (8 * n) / k + ((8 * n) % k == 0 ? 0 : 1);
            Console.WriteLine(redNotes + greenNotes + blueNotes);
        }
    }
}
