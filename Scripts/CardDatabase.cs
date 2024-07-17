using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    
    public static List<Card> cardList = new List<Card>();

    void Awake() {
        cardList.Add(new Card(0, "None", "None", 0)); 
        cardList.Add(new Card(1, "2 of Spades", "Spade", 2)); 
        cardList.Add(new Card(2, "3 of Spades", "Spade", 3)); 

    
    
    }




}
