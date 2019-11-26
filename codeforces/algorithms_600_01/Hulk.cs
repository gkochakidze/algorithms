// https://codeforces.com/problemset/problem/705/A
using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Hulk
    {
        public void ParseSolveWrite()
        {
            var layers = Parse();
            var result = Solve(layers);
            Write(result);
        }

        private int Parse()
        {
            var layers = int.Parse(Console.ReadLine());
            return layers;
        }

        private string Solve(int layers)
        {
            var feelingsList = new List<string>();
            for (int i = 0; i < layers - 1; i++)
                feelingsList.Add((i % 2 == 0) ? "I hate that" : "I love that");
            feelingsList.Add(((layers - 1) % 2 == 0) ? "I hate it" : "I love it");
            return string.Join(" ", feelingsList);
        }

        private void Write(string result)
        {
            Console.WriteLine(result);
        }
    }
}
