// https://codeforces.com/problemset/problem/136/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class Presents
    {
        public void Solve()
        {
            var givenGifts = new int[int.Parse(Console.ReadLine())];
            var takenGifts = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            for (int i = 0; i < takenGifts.Length; i++)
                givenGifts[takenGifts[i] - 1] = i + 1;
            Console.WriteLine(string.Join(" ", givenGifts));
        }
    }
}
