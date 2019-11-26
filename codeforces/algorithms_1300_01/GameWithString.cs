// https://codeforces.com/contest/1104/problem/B

using System;
using System.Collections.Generic;

namespace algorithms_1300_01
{
    public class GameWithString
    {
        public void Solve()
        {
            var text = Console.ReadLine();
            var stack = new Stack<char>();
            for (int i = 0; i < text.Length; i++)
                if (stack.Count > 0 && stack.Peek() == text[i]) stack.Pop();
                else stack.Push(text[i]);
            Console.WriteLine((text.Length - stack.Count) / 2 % 2 == 1 ? "Yes" : "No");
        }
    }
}
