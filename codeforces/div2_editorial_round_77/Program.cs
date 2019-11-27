using System;
using System.Collections.Generic;
using System.Linq;

namespace div2_editorial_round_77
{
    class Program
    {
        static void Main(string[] args)
        {
            C();
        }



        public static void C()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                var a = Math.Max(array[0], array[1]);
                var b = Math.Min(array[0], array[1]);
                var k = array[2];
                var div = commDiv((int) a, (int) b);
                a = a / div;
                b = b / div;
                if (a % b == 0 && a / b > k)
                {
                    Console.WriteLine("REBEL");
                }
                else if (a % b != 0 && (a - 1) % b != 0 && (1 + (a - 1) / b) > k)
                {
                    Console.WriteLine("REBEL");
                }
                else if (a % b != 0 && (a - 1) % b == 0 && ((a - 1) / b) >= k)
                {
                    Console.WriteLine("REBEL");
                }
                else
                {
                    Console.WriteLine("OBEY");
                }
            }
        }

        static int gcd(int a, int b)
        {
            if (a == 0)
                return b;

            return gcd(b % a, a);
        }

        static int commDiv(int a, int b)
        { 
            int n = gcd(a, b);

            int result = 0;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {

                if (n % i == 0)
                {

                    if (n / i == i)
                        result += 1;
                    else
                        result += 2;
                }
            }

            return result;
        }

        public static void B()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                var a = Math.Max(array[0], array[1]);
                var b = Math.Min(array[0], array[1]);
                if (a > 2 * b || (a + b) % 3 != 0)
                    Console.WriteLine("No");
                else
                    Console.WriteLine("Yes");
            }
        }

        public static void A()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var array = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                var radiatorsAmount = array[0];
                var sectionsAmount = array[1];
                var costs = new long[radiatorsAmount > sectionsAmount ? sectionsAmount : radiatorsAmount];
                int sum = 0;
                while (sum < sectionsAmount)
                {
                    for (int j = 0; j < costs.Length && sum < sectionsAmount; j++)
                    {
                        costs[j]++;
                        sum++;
                    }
                }
                var answer = costs.Aggregate(0L, (acc, x) => acc + x * x);
                Console.WriteLine(answer);
            }
        }
    }
}
