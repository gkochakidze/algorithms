// https://codeforces.com/problemset/problem/1136/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class NastyaIsReadingBook
    {
        static void Solve()
        {
            var chaptersAmount = int.Parse(Console.ReadLine());
            var chapters = Enumerable
                .Range(1, chaptersAmount)
                .Select(x => int.Parse(Console.ReadLine().Split(new char[] { ' ' })[1]))
                .ToArray();
            var notReadPage = int.Parse(Console.ReadLine());
            for (int i = 0; i < chapters.Length; i++)
            {
                if (chapters[i] >= notReadPage)
                {
                    Console.WriteLine(chapters.Length - i);
                    return;
                }
            }
        }
    }
}
