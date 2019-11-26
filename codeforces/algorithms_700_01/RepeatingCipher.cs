// https://codeforces.com/problemset/problem/1095/A
using System;

namespace algorithms_700_01
{
    public class RepeatingCipher
    {
        public void Solve()
        {
            var encodedLength = int.Parse(Console.ReadLine());
            var encodedText = Console.ReadLine();
            var decodedText = "";
            for (int i = 0, length = 0; i < encodedLength; i += i + 1, length++)
                decodedText += encodedText[i];
            Console.WriteLine(decodedText);
        }
    }
}
