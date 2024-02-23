using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CardHashcoding
{
    // A Test behaves as an ordinary method
    [Test]
    public void GetHashcode_Expected2001()
    {
        CardData card = new CardData((CardShape)2, (CardColor)0, (CardFill)0, (Count)1);
        var hashcode = card.GetHashCode();
        Assert.AreEqual(hashcode,2001);
    }
    
    [Test]
    public void GetHashcode_Expected1111()
    {
        CardData card = new CardData((CardShape)1, (CardColor)1, (CardFill)1, (Count)1);
        var hashcode = card.GetHashCode();
        Assert.AreEqual(hashcode,1111);
    }
    
}
