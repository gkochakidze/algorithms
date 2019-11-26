// https://codeforces.com/problemset/problem/1167/A
using System;

namespace algorithms_700_01
{
    public class PhoneNumber
    {
        public void Solve()
        {
            var phoneNumberLength = 11;
            var phoneNumberPrefix = '8';
            var testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var textLength = int.Parse(Console.ReadLine());
                var text = Console.ReadLine();
                var index = text.IndexOf(phoneNumberPrefix);
                if (index >= 0 && textLength - index >= phoneNumberLength)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
