// https://codeforces.com/problemset/problem/996/A
using System;

namespace Algorithms
{
    public class HitLottery
    {
        public void ParseSolveWrite()
        {
            var money = Parse();
            var quantityOfBills = Solve(money);
            Write(quantityOfBills);
        }

        private int Parse()
        {
            var money = int.Parse(Console.ReadLine());
            return money;
        }

        private int Solve(int money)
        {
            var bills = new int[5] { 1, 5, 10, 20, 100 };
            return getMinimumQuantityOfBills(money, bills, bills.Length - 1);
        }

        private int getMinimumQuantityOfBills(int money, int[] bills, int index)
        {
            if (money == 0 || index < 0) return 0;
            var billsCount = money / bills[index];
            return billsCount + getMinimumQuantityOfBills(money % bills[index], bills, index - 1);
        }

        private void Write(int quantityOfBills)
        {
            Console.WriteLine(quantityOfBills);
        }
    }
}
