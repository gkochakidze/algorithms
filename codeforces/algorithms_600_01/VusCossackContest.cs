// https://codeforces.com/problemset/problem/1186/A
using System;
using System.Linq;

namespace Algorithms
{
    public class VusCossackContent
    {
        public void ParseSolveWrite()
        {
            var (participants, pens, notebooks) = Parse();
            var result = Solve(participants, pens, notebooks);
            Write(result);
        }

        private  (int, int, int) Parse()
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(x => int.Parse(x))
                .ToArray();
            return (array[0], array[1], array[2]);
        }

        private string Solve(int participants, int pens, int notebooks)
        {
            return participants <= pens && participants <= notebooks ? "Yes" : "No";
        }

        private void Write(string allWaysToDivideTeam)
        {
            Console.WriteLine(allWaysToDivideTeam);
        }
    }
}
