using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsManager : MonoBehaviour {

    // list of the current cards
    public List<GameObject> Cards;

    // list of the total cards (all of them)
    public List<GameObject> TotalCards;

    // list of the cards names
    public List<string> cardsNames;

    public void OnEnable()
    {
        // clear the list so it doesn't add the same cards
        cardsNames.Clear();

        // get the names of all the cards
        foreach (var card in Cards)
        {
            cardsNames.Add(card.name);
        }
    }
}
