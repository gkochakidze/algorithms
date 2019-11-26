// https://codeforces.com/problemset/problem/1173/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class NauuoAndVotes
    {
        public void Solve()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            if (array[0] > array[1] + array[2])
                Console.WriteLine("+");
            else if (array[1] > array[0] + array[2])
                Console.WriteLine("-");
            else if (array[0] == array[1] && array[2] == 0)
                Console.WriteLine("0");
            else
                Console.WriteLine("?");
        }
    }
}
