// https://codeforces.com/problemset/problem/658/A
using System;
using System.Linq;

namespace algorithms_700_01
{
    public class BearAndReverseRadewoosh
    {
        public void Solve()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            var minuteCost = array[1];
            var scores = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            var times = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            int limakPoints = 0, limakTime = 0;
            int radewooshPoints = 0, radewooshTime = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                limakTime += times[i];
                limakPoints += Math.Max(0, scores[i] - minuteCost * limakTime);
                radewooshTime += times[scores.Length - i - 1];
                radewooshPoints += Math.Max(0, scores[scores.Length - i - 1] - minuteCost * radewooshTime);
            }
            if (limakPoints > radewooshPoints)
                Console.WriteLine("Limak");
            else if (limakPoints < radewooshPoints)
                Console.WriteLine("Radewoosh");
            else
                Console.WriteLine("Tie");
        }
    }
}
