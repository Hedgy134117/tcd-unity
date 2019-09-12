using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileControlsP1 : MonoBehaviour {

    public PlayerOneMovement playerOneMovement;
    public GameObject p1;

    private void Start()
    {
        playerOneMovement = Resources.FindObjectsOfTypeAll<PlayerOneMovement>()[0];
        p1 = GameObject.FindGameObjectWithTag("currentp1");
    }

    public void Left()
    {
        playerOneMovement.Left(p1);
    }

    public void Jump()
    {
        if (playerOneMovement.floored == true && playerOneMovement.flyingEnabled == false)
        {
            playerOneMovement.Jump(p1);
        }
        else if (playerOneMovement.flyingEnabled == true)
        {
            playerOneMovement.Fly(p1);
        }
    }

    public void Right()
    {
        playerOneMovement.Right(p1);
    }

    public void Down()
    {
        playerOneMovement.Down(p1);
    }
}
