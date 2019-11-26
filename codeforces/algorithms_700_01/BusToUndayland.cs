// https://codeforces.com/problemset/problem/711/A
using System;

namespace algorithms_700_01
{
    public class BusToUndayland
    {
        public void Solve()
        {
            var busLength = int.Parse(Console.ReadLine());
            var canBeSeatedOutput = "YES";
            var canBeSeated = false;
            for (int i = 0; i < busLength; i++)
            {
                var row = Console.ReadLine();
                if (row[0] == row[1] && row[0] == 'O' && !canBeSeated)
                {
                    canBeSeated = true;
                    canBeSeatedOutput += $"\n++{row.Substring(2, 3)}";
                }
                else if (row[3] == row[4] && row[3] == 'O' && !canBeSeated)
                {
                    canBeSeated = true;
                    canBeSeatedOutput += $"\n{row.Substring(0, 3)}++";
                }
                else
                    canBeSeatedOutput += $"\n{row}";
            }
            Console.WriteLine(canBeSeated ? canBeSeatedOutput : "NO");
        }
    }
}
