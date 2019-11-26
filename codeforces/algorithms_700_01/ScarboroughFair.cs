// https://codeforces.com/problemset/problem/897/A
using System;
using System.Linq;
using System.Text;

namespace algorithms_700_01
{
    public class ScarboroughFair
    {
        public void Solve()
        {
            var operationsCount = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray()[1];
            var originalText = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < operationsCount; i++)
            {
                var operation = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
                var rangeStart = int.Parse(operation[0]);
                var rangeEnd = int.Parse(operation[1]);
                var characterToChange = operation[2][0];
                var characterToBecome = operation[3][0];
                for (int j = rangeStart - 1; j < rangeEnd; j++)
                    if (originalText[j] == characterToChange)
                        originalText[j] = characterToBecome;
            }
            Console.WriteLine(originalText.ToString());
        }
    }
}
