// https://codeforces.com/problemset/problem/721/A
using System;
using System.Linq;
using System.Collections.Generic;

namespace algorithms_700_01
{
    public class JapaneseCrossword
    {
        public void Solve()
        {
            var rowLength = int.Parse(Console.ReadLine());
            var rowCrossword = Enumerable.Range(1, rowLength).Select(x => "" + (char)Console.Read()).ToList();
            rowCrossword.Add("W");
            var groupsNumber = 0;
            var groupLength = 0;
            var groupsLength = new List<int>();
            for (int i = 1; i < rowCrossword.Count; i++)
            {
                if (rowCrossword[i - 1] == "W") continue;
                if (rowCrossword[i] == rowCrossword[i - 1])
                {
                    groupLength++;
                }
                else
                {
                    groupsNumber++;
                    groupsLength.Add(groupLength + 1);
                    groupLength = 0;
                }
            }
            Console.WriteLine(groupsNumber);
            Console.WriteLine(string.Join(" ", groupsLength));
        }
    }
}
