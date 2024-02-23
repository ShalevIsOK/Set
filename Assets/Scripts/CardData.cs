using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardData
{
    public const int traitCount = 4;
    public const int traitOptions = 3;
    public readonly int[] cardTraits; 

    public CardData(CardShape shape, CardColor color, CardFill fill, Count count) //change to enums
    {
        cardTraits = new []{ (int)shape, (int)color, (int)fill, (int)count};
        foreach (var trait in cardTraits)
        {
            if (trait < 0 || trait > traitOptions-1)
            {
                throw new Exception($"trait index out of 0-2 range ({trait})");
            }
        }
    }

    public CardData(int[] cardTraits)
    {
        this.cardTraits = cardTraits;
    }

    public override int GetHashCode() //an int to use as key!
    {
        int hashCode = 0;
        int digit = (int)Math.Pow(10, traitCount-1); // 1000 for 4 digits, 100 for 3 etc
        for (int i = 0; i < traitCount; i++)
        {
            hashCode += digit * cardTraits[i];
            digit /= 10;
        }
        Debug.Log(hashCode);
        return hashCode;
    }

   

    

}
