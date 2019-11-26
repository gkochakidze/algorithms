// https://codeforces.com/problemset/problem/1030/A
using System;

namespace Algorithms
{
    public class SearchEasyProblem
    {
        public void ParseSolveWrite()
        {
            var recipientsAnswers = Parse();
            var result = Solve(recipientsAnswers);
            Write(result);
        }

        private int[] Parse()
        {
            var recipientsQuantity = int.Parse(Console.ReadLine());
            var recipientsAnswersString = Console.ReadLine();
            var recipientsAnswers = new int[recipientsQuantity];
            for (int i = 0; i < recipientsQuantity; i++)
                recipientsAnswers[i] = int.Parse(recipientsAnswersString.Substring(2 * i, 1));
            return recipientsAnswers;
        }

        private string Solve(int[] recipientsAnswers)
        {
            for (int i = 0; i < recipientsAnswers.Length; i++)
                if (recipientsAnswers[i] == 1) return "HARD";
            return "EASY";
        }

        private void Write(string result)
        {
            Console.WriteLine(result);
        }
    }
}
