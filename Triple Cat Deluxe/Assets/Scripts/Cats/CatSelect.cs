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

    // button enlarge when hover
    public void mouseEnter()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void mouseExit()
    {
        this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

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

}
