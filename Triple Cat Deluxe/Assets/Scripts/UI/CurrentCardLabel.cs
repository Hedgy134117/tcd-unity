using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentCardLabel : MonoBehaviour {

    public CardsManager cardsManager;

	// Update is called once per frame
	void Update () {
        // look at each card
        foreach (var card in cardsManager.TotalCards)
        {
            // if it is the current card
            if(card.tag == "currentCard")
            {
                // set the text equal to the name of the card
                this.GetComponent<TMP_Text>().text = "Current Card: " + card.name;
            }
        }
	}
}
