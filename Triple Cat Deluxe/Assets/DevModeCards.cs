using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevModeCards : MonoBehaviour {

    public CardsManager cardsManager;

    public void Update()
    {
        // don't allow the user to select a card that has already been drawn
        if(cardsManager.cardsNames.Contains(this.name) == false)
        {
            this.GetComponent<Button>().interactable = false;
        }
    }

    public void selectCard()
    {
        // check each card and if the card is the current card, make it not the current card
        foreach (var card in cardsManager.Cards)
        {
            if(card.tag == "currentCard")
            {
                card.tag = "Card";
            }
        }

        // check each card and if the card is equal to the name of the button, make that card the current card
        foreach (var card in cardsManager.Cards)
        {
            if(card.name == this.name)
            {
                card.tag = "currentCard";
            }
        }
    }
}
