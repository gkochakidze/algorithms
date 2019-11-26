// https://codeforces.com/problemset/problem/344/A

using System;

namespace algorithms_700_01
{
    public class Magnets
    {
        public void Solve()
        {
            var numberOfPiles = int.Parse(Console.ReadLine());
            var numberOfGroups = 1;
            if (numberOfPiles == 1)
            {
                Console.WriteLine(numberOfGroups);
                return;
            }
            var previousPile = Console.ReadLine();
            for (var i = 0; i < numberOfPiles - 1; i++)
            {
                var currentPile = Console.ReadLine();
                if (previousPile.Substring(1, 1) == currentPile.Substring(0, 1))
                    numberOfGroups++;
                previousPile = currentPile;
            }
            Console.WriteLine(numberOfGroups);
        }
    }
}
