using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class developerMode : MonoBehaviour {

    // variables
    public float timeLeft = 3f;
    public bool devMode = false;

    public Sprite devModeBG;

    public Sprite devPlayButton;
    public Sprite devControlsButton;
    public Sprite devHTPButton;
    public Sprite devCreditsButton;

    public GameObject devCanvas;
    public GameObject floor;

	// Update is called once per frame
	void Update () {
        // check if player is holding down T C D keys	
        if (Input.GetKey(KeyCode.T) && devMode == false && SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Input.GetKey(KeyCode.C) && devMode == false && SceneManager.GetActiveScene().buildIndex == 0)
            {
                if (Input.GetKey(KeyCode.D) && devMode == false && SceneManager.GetActiveScene().buildIndex == 0)
                {
		            // start 3 second timer
                    Debug.Log("d");
                    timeLeft -= Time.deltaTime;

                    if (timeLeft <= 0f)
                    {
                        // enable devmode
                        DevMode();
                    }
                }
            }
        }

        // devMode actions
        if (devMode == true && SceneManager.GetActiveScene().name == "SampleScene")
        {
            // check if devmode is active (can only be activated at the start) 
            // and set the devmodemanager in this scene to true and then
            // delete the old developermodemanager
            if(GameObject.Find("DeveloperModeManager"))
            {
                GameObject.Find("DevModeManager").GetComponent<developerMode>().devMode = GameObject.Find("DeveloperModeManager").GetComponent<developerMode>().devMode;
                Destroy(GameObject.Find("DeveloperModeManager"));
            }

            // press the ` key to enable or disable the devCanvas & activate the pause effect (stop time)
            if(Input.GetKeyDown(KeyCode.BackQuote) && devCanvas.activeInHierarchy == false)
            {
                floor.GetComponent<ShrinkingFloor>().sizeToShrinkBy = 0f;
                Time.timeScale = 0f;

                devCanvas.SetActive(true);
            }
            else if(Input.GetKeyDown(KeyCode.BackQuote) && devCanvas.activeInHierarchy == true)
            {
                floor.GetComponent<ShrinkingFloor>().sizeToShrinkBy = 0.001f;
                Time.timeScale = 1f;

                devCanvas.SetActive(false);
            }
        } 
	}

    public void DevMode()
    {
        // enable devmode
        devMode = true;
        // reset timer
        timeLeft = 3f;

        // change sprites to devmode sprites
        GameObject.Find("BG").GetComponent<Image>().sprite = devModeBG;
        GameObject.Find("PlayButton").GetComponent<Image>().sprite = devPlayButton;
        GameObject.Find("HTPButton").GetComponent<Image>().sprite = devHTPButton;
        GameObject.Find("ControlsButton").GetComponent<Image>().sprite = devControlsButton;
        GameObject.Find("CreditsButton").GetComponent<Image>().sprite = devCreditsButton;
    }
}
