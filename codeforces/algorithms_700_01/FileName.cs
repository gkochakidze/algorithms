// https://codeforces.com/problemset/problem/978/B
using System;

namespace algorithms_700_01
{
    public class FileName
    {
        public void Solve()
        {
            var occurrenceLength = 0;
            var deletedCount = 0;
            var fileLength = int.Parse(Console.ReadLine());
            for (int i = 0; i < fileLength; i++)
            {
                var letter = (char)Console.Read();
                if (letter != 'x')
                    occurrenceLength = 0;
                else
                    if (occurrenceLength == 2)
                    deletedCount++;
                else
                    occurrenceLength++;
            }
            Console.WriteLine(deletedCount);
        }
    }
}
