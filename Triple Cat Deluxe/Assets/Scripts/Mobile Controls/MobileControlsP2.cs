using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileControlsP2 : MonoBehaviour {

    public PlayerTwoMovement playerTwoMovement;
    public GameObject p2;

    private void Start()
    {
        playerTwoMovement = Resources.FindObjectsOfTypeAll<PlayerTwoMovement>()[0];
        p2 = GameObject.FindGameObjectWithTag("currentp2");
    }

    public void Left()
    {
        playerTwoMovement.Left(p2);
    }

    public void Jump()
    {
        if (playerTwoMovement.floored == true && playerTwoMovement.flyingEnabled == false)
        {
            playerTwoMovement.Jump(p2);
        }
        else if (playerTwoMovement.flyingEnabled == true)
        {
            playerTwoMovement.Fly(p2);
        }
    }

    public void Right()
    {
        playerTwoMovement.Right(p2);
    }

    public void Down()
    {
        playerTwoMovement.Down(p2);
    }
}
