// https://codeforces.com/problemset/problem/867/A
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class BetweenOffices
    {
        public void ParseSolveWrite()
        {
            var staysInCities = Parse();
            var answer = Solve(staysInCities);
            Write(answer);
        }

        private List<string> Parse()
        {
            var numberOfDays = int.Parse(Console.ReadLine());
            var staysInCities = Enumerable
                .Range(1, numberOfDays)
                .Select(x => char.ToString((char)Console.Read()))
                .ToList();
            return staysInCities;
        }

        private string Solve(List<string> staysInCities)
        {
            var numberOfFliesToSanFrancisco = 0;
            var numberOfFliesToSeatle = 0;
            for (int i = 0; i < staysInCities.Count - 1; i++)
            {
                var currentCity = staysInCities[i];
                var nextCity = staysInCities[i + 1];
                if (currentCity == nextCity) continue;
                if (currentCity == "S" && nextCity == "F") numberOfFliesToSanFrancisco++;
                if (currentCity == "F" && nextCity == "S") numberOfFliesToSeatle++;
            }
            return numberOfFliesToSanFrancisco > numberOfFliesToSeatle ? "YES" : "NO";
        }

        private void Write(string answer)
        {
            Console.WriteLine(answer);
        }
    }
}
