using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName; //e.g. 9 of hearts
    public string suit; // hearts
    public int value; //9


    public Text nameText;
    public Text idText;
    public Text suitText;
    public Text numberText;



    // Start is called before the first frame update
    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayId];
        // id = displayCard[0].id;
        
    }

    // Update is called once per frame
    void Update()
    {
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        suit = displayCard[0].suit;
        value = displayCard[0].value;

        nameText.text = " " + cardName;
        idText.text = " " + id;
        suitText.text = " " + suit;
        numberText.text = " " + value;


    }
}
