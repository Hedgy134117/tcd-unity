using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevModeCards : MonoBehaviour {

    public CardsManager cardsManager;

    public void selectCard()
    {
        // check each card and if the card is the current card, make it not the current card
        foreach (var card in cardsManager.TotalCards)
        {
            if(card.tag == "currentCard")
            {
                card.tag = "Card";
            }
        }

        // check each card and if the card is equal to the name of the button, make that card the current card
        foreach (var card in cardsManager.TotalCards)
        {
            if(card.name == this.name)
            {
                card.tag = "currentCard";
            }
        }
    }
}
