// https://codeforces.com/problemset/problem/200/B
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class Drinks
    {
        public void solve()
        {
            var numberOfDrinks = double.Parse(Console.ReadLine());
            var sumOfOrangeJuice = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(x => int.Parse(x))
                .Aggregate(0, (acc, x) => acc + x);
            Console.WriteLine(sumOfOrangeJuice / numberOfDrinks);
        }
    }
}
