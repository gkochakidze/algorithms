// https://codeforces.com/problemset/problem/595/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class VitalyAndNight
    {
        public void Solve()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            var housesCountWithLightsOn = 0;
            for (int i = 0; i < array[0]; i++)
            {
                var apartments = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < apartments.Length; j += 2)
                {
                    if (apartments[j] == 1 || apartments[j + 1] == 1)
                        housesCountWithLightsOn++;
                }
            }
            Console.WriteLine(housesCountWithLightsOn);
        }
    }
}
