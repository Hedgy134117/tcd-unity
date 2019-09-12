using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentPlayer : MonoBehaviour {

    // player selecting
    public int playerSelecting;
    // player selecting display
    public TMP_Text text;

    private void Start()
    {
        // at the start of cat select player 1 will select first
        playerSelecting = 1;
    }

    public void Update()
    {
        // if the player selecting is greater than zero
        if(playerSelecting > 0)
        {
            // switch based on who is selecting
            switch(playerSelecting)
            {
                // if p1 is selecting then the text says p1
                case 1:
                    text.text = "PLAYER 1";
                    break;

                // if p2 is selecting then the text says p2
                case 2:
                    text.text = "PLAYER 2";
                    break;
            }
        }
        // if playerSelecting is not player 2 or 1 then it is no one 
        else
        {
            text.text = "";
        }
    }
}
