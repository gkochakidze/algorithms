// https://codeforces.com/problemset/problem/1207/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class TwoTypesOfBurger
    {
        public void Solve()
        {
            var queriesAmount = int.Parse(Console.ReadLine());
            for (int i = 0; i < queriesAmount; i++)
            {
                var ingredients = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                var prices = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                var buns = ingredients[0];
                var (primaryIngredient, backupIngredient, primaryPrice, backupPrice) = prices[0] > prices[1]
                    ? (ingredients[1], ingredients[2], prices[0], prices[1])
                    : (ingredients[2], ingredients[1], prices[1], prices[0]);
                var price = Math.Min(buns / 2, primaryIngredient) * primaryPrice + Math.Min(Math.Max(buns - 2 * primaryIngredient, 0) / 2, backupIngredient) * backupPrice;
                Console.WriteLine(price);
            }
        }
    }
}
