using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CatSelect : MonoBehaviour {

    public CatManager catManager;
    public CurrentPlayer currentPlayer;

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
        if(currentPlayer.playerSelecting == 0)
        {
            this.gameObject.GetComponent<Button>().interactable = false;
        }
    }

    public void selectCat()
    {
        if(currentPlayer.playerSelecting == 1)
        {
            catManager.p1 = this.gameObject.name;
            currentPlayer.playerSelecting += 1;
        }
        else if(currentPlayer.playerSelecting == 2)
        {
            catManager.p2 = this.gameObject.name;
            currentPlayer.playerSelecting = 0;
        }

        this.gameObject.GetComponent<Button>().interactable = false;
    }

}
