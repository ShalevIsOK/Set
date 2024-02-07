using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public struct CardData: IEnumerable<int>
{
    private int shape;
    private int color;
    private int fill;
    private int number;

    public CardData(int shape, int color, int fill, int number)
    {
        this.shape = shape;
        this.color = color;
        this.fill = fill;
        this.number = number;
        //add iteration to check 0-2
    }
    
    
    

    public IEnumerator<int> GetEnumerator()
    {
        yield return shape;
        yield return color;
        yield return fill;
        yield return number;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
