// https://codeforces.com/problemset/problem/1244/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class PensAndPencils
    {
        public void Solve()
        {
            var testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                var pensAmount = array[0] / array[2] + (array[0] % array[2] == 0 ? 0 : 1);
                var pencilsAmount = array[1] / array[3] + (array[1] % array[3] == 0 ? 0 : 1);
                Console.WriteLine(pensAmount + pencilsAmount > array[4] ? "-1" : pensAmount + " " + pencilsAmount);
            }
        }
    }
}
