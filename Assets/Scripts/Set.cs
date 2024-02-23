using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set
{
     private HashSet<int> cardsInSet;
     private int setID { get; set; } //find way to create ID, maybe no point in doing that though
     
     public Set(CardData card1, CardData card2, CardData card3)
     {
          cardsInSet = new() { card1.GetHashCode(), card2.GetHashCode(), card3.GetHashCode() };
     }
     
     
     
     
     
     
     //a list of existing sets will check if a set exists in it. maybe a dictionary. 
     
}
