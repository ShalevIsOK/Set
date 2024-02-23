using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetChecker
{
    public bool IsSet()
    {
        //might not be needed in the actually flow of the game, but at least for 
        //verification and testing of the logic
        throw new NotImplementedException();
    }

    public CardData getCompletingCard(CardData card1, CardData card2)
    {
        int[] newCardTraits = new int[CardData.traitCount];
        for (int i = 0; i < CardData.traitCount; i++)
        {
            var sum = card1.cardTraits[i] + card2.cardTraits[i];
            var missingDigit = 0;
            while (sum % CardData.traitOptions != 0)
            {
                sum++;
                missingDigit++;
            }

            newCardTraits[i] = missingDigit;
        }
        return new CardData(newCardTraits);
    }
    
    
}
