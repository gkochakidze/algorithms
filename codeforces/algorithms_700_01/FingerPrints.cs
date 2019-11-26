// https://codeforces.com/problemset/problem/994/A
using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithms_700_01
{
    public class FingerPrints
    {
        public void Solve()
        {
            Console.ReadLine();
            var fingerPrintDigits = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x));
            var possibleSecretDigits = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x));
            var secretCodeDigits = new List<int>();
            foreach (var fingerPrintDigit in fingerPrintDigits)
                if (possibleSecretDigits.Contains(fingerPrintDigit))
                    secretCodeDigits.Add(fingerPrintDigit);
            Console.WriteLine(string.Join(" ", secretCodeDigits));
        }
    }
}
