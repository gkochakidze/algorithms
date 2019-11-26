// https://codeforces.com/problemset/problem/1097/A
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class GennadyCardGame
    {
        public void ParseSolveWrite()
        {
            var (cardOnDeck, cardsInHand) = Parse();
            var result = Solve(cardOnDeck, cardsInHand);
            Write(result);
        }

        private (Card, List<Card>) Parse()
        {
            var input = Console.ReadLine();
            var cardOnDeck = new Card
            {
                Rank = input.Substring(0, 1),
                Suit = input.Substring(1, 1)
            };
            input = Console.ReadLine();
            var cardsInHand = input
                .Split(new char[] { ' ' })
                .Select((value) =>
                    new Card
                    {
                        Rank = value.Substring(0, 1),
                        Suit = value.Substring(1, 1)
                    }
                )
                .ToList();
            return (cardOnDeck, cardsInHand);
        }

        private string Solve(Card cardOnDeck, List<Card> cardsInHand)
        {
            foreach (var card in cardsInHand)
            {
                if (isSameRank(card, cardOnDeck) || isBiggerSameSuit(card, cardOnDeck))
                    return "YES";
            }
            return "NO";
        }

        private bool isBiggerSameSuit(Card card, Card cardOnDeck)
        {
            return card.Suit == cardOnDeck.Suit;
        }

        private bool isSameRank(Card card, Card cardOnDeck)
        {
            return card.Rank == cardOnDeck.Rank;
        }

        private void Write(string result)
        {
            Console.WriteLine(result);
        }

        class Card
        {
            public string Rank { get; set; }

            public string Suit { get; set; }
        }
    }
}
