using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

class CardData
{
    private const int traitCount = 4;
    private int[] cardTraits;

    public CardData(int shape, int color, int fill, int number)
    {
        cardTraits = new []{ shape, color, fill, number };
        foreach (var trait in cardTraits)
        {
            if (trait < 0 || trait > 2)
            {
                throw new Exception($"trait index out of 0-2 range ({trait})");
            }
        }
    }

    public override int GetHashCode() //an int to use as key!
    {
        int hashCode = 0;
        int digit = 10 * traitCount - 1; // 1000 for 4 digits, 100 for 3 etc
        for (int i = 0; i < traitCount; i++)
        {
            hashCode += digit * cardTraits[i];
            digit /= 10;
        }

        return hashCode;
    }

    public static CardData GetCompletingCard(CardData card1, CardData card2)
    {
        throw new NotImplementedException();
    }

    

}
