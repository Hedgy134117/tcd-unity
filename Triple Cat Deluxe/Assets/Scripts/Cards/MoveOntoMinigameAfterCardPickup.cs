using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveOntoMinigameAfterCardPickup : MonoBehaviour {

    // Variables
    // Time to move from drawing to minigame
    public float _timeToMoveOn = 5f;

    // Arrays of GameObjects to disable/enable
    public GameObject[] toDisable;
    public GameObject[] toEnable;

    // Draw Button
    public Button drawButton;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        if (drawButton.IsInteractable() == false)
        {
            // Start timer
            _timeToMoveOn -= Time.deltaTime;

            // When timer ends
            if (_timeToMoveOn <= 0f)
            {
                // Everything in toDisable is disabled
                foreach (var item in toDisable)
                {
                    item.SetActive(false);
                }
                // Everything in toEnable is enabled
                foreach (var item in toEnable)
                {
                    item.SetActive(true);
                }

                // reset timer
                _timeToMoveOn = 5f;
            }
        }
	}
}
