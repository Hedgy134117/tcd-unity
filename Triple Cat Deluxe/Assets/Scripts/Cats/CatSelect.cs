using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CatSelect : MonoBehaviour {

    
    // catmanager
    public CatManager catManager;
    // currentplayer
    public CurrentPlayer currentPlayer;
    // lore text
    public TMP_Text lore;

    private void Update()
    {
        // if both players have selected then make this button not clickabe
        if(currentPlayer.playerSelecting == 0)
        {
            this.gameObject.GetComponent<Button>().interactable = false;
        }
    }

    public void selectCat()
    {
        // 1st players selection
        if(currentPlayer.playerSelecting == 1)
        {
            catManager.p1 = this.gameObject.name;
            currentPlayer.playerSelecting += 1;
        }
        // 2nd players selection
        else if(currentPlayer.playerSelecting == 2)
        {
            catManager.p2 = this.gameObject.name;
            currentPlayer.playerSelecting = 0;
        }

        // once this player has selected then make this button not clickabe
        this.gameObject.GetComponent<Button>().interactable = false;
    }

    public void selectLore()
    {
        lore.fontStyle = TMPro.FontStyles.Normal;
        lore.fontSize = 20;

        switch (this.gameObject.name)
        {
            case "Sausage":
                lore.text = "Who ordered the bratwurst?";
                break;

            case "Queso":
                lore.text = "He's too pure for the natural world. He must fight for his right to maintain his cuteness.";
                break;

            case "Canada":
                lore.text = "The United Nations didn't want him anymore, so he takes his aggression out with fighting. Good thing he has great health care.";
                lore.fontSize -= 4;
                break;

            case "JohnJonJean":
                lore.text = "These boys trained to fight in a specialized cat Boot Camp in France.";
                break;

            case "Owo":
                lore.fontStyle = TMPro.FontStyles.Italic;
                lore.text = "nuzzles you off the platform";
                break;

            case "Jupiter":
                lore.text = "Who woulda thunk that the planet Jupiter was just a giant cat this whole time???";
                break;

            case "Gwendoline":
                lore.text = "Nobody really knows how she got so small. Some speculate she fell in a pool of radioactive waste.";
                break;

            case "Igor":
                lore.text = "He's lived alone in his cat pin for 30 years. He's probably not even a cat. Nobody knows.";
                break;

            case "Texas":
                lore.text = "Fastest purrer in the west. He puts the boy in cowboy.";
                break;

            case "Washington":
                lore.text = "Don't be fooled by this guy's sleazy attempts at shapeshifting. This boy is a cat and a cat only.";
                break;

            case "Qwerty":
                lore.text = "01010111 01101000 01100001 01110100 00100111 01110011 00100000 01100001 00100000 01100011 01100001 01110100 0011111";
                lore.fontSize -= 6;
                break;

            case "Toothpick":
                lore.text = "One day he STRETCHED too far and ended up here. Good thing he's extraordinarily good at knocking cats off of a designated platform.";
                lore.fontSize -= 6;
                break;
        }
    }
}
