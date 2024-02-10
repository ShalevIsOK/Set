using System;
using System.Collections.Generic;

namespace DefaultNamespace
{
    public class DeckData
    {
        private DeckConfig deckConfig;
        
        private HashSet<CardData> drawPile;
        private HashSet<CardData> board;
        private HashSet<CardData> discardPile; //is it needed? We'll find out!

        public CardData[] Draw(int amount)
        {
            throw new NotImplementedException();
        }

        public void Discard(CardData[] cards)
        {
            throw new NotImplementedException();
        }

        public bool IsOnBoard(CardData card)
        {
            return board.Contains(card);
        }
        
    }
}