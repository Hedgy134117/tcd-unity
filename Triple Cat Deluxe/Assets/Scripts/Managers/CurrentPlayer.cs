using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentPlayer : MonoBehaviour {

    public int playerSelecting;
    public TMP_Text text;

    private void Start()
    {
        playerSelecting = 1;
    }

    public void Update()
    {
        if(playerSelecting > 0)
        {
            switch(playerSelecting)
            {
                case 1:
                    text.text = "PLAYER ONE";
                    break;

                case 2:
                    text.text = "PLAYER TWO";
                    break;
            }
        }
        else
        {
            text.text = "";
        }
    }
}
