// https://codeforces.com/problemset/problem/581/A
using System;

namespace algorithms_700_01
{
    public class VasyaHipster
    {
        public void solve()
        {
            var input = Console.ReadLine();
            var numberOfRedSocks = int.Parse(input.Split(new char[] { ' ' })[0]);
            var numberOfBlueSocks = int.Parse(input.Split(new char[] { ' ' })[1]);
            Console.WriteLine(Math.Min(numberOfRedSocks, numberOfBlueSocks) + " " + Math.Abs(numberOfRedSocks - numberOfBlueSocks) / 2);
        }
    }
}
