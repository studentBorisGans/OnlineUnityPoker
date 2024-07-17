using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 [System.Serializable]


public class Card
{
    public int id;
    public string cardName; //e.g. 9 of hearts
    public string suit; // hearts
    public int value; //9
    

    public Card()
    {

    }

    public Card(int Id, string CardName, string Suit, int Value)
    {
        id = Id;
        cardName = CardName;
        suit = Suit;
        value = Value;

    }




}
