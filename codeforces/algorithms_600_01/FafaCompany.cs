// https://codeforces.com/problemset/problem/935/A
using System;

namespace Algorithms
{
    public class FafaCompany
    {
        public void ParseSolveWrite()
        {
            var employeesQuantity = Parse();
            var allWaysToDivideTeam = Solve(employeesQuantity);
            Write(allWaysToDivideTeam);
        }

        private int Parse()
        {
            int employeesQuantity = int.Parse(Console.ReadLine());
            return employeesQuantity;
        }

        private int Solve(int employeesQuantity)
        {
            var allWaysToDivideTeam = 0;
            for (int i = 1; i * i <= employeesQuantity; i++)
                if (employeesQuantity % i == 0)
                    allWaysToDivideTeam += (i * i == employeesQuantity || i == 1) ? 1 : 2;
            return allWaysToDivideTeam;
        }

        private void Write(int allWaysToDivideTeam)
        {
            Console.WriteLine(allWaysToDivideTeam);
        }
    }
}
