using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class developerMode : MonoBehaviour {

    public float timeLeft = 3f;
    public bool devMode = false;

    public Sprite devModeBG;

	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.T) && devMode == false && SceneManager.GetActiveScene().buildIndex == 0)
	// check if player is holding down T C D keys	
        if (Input.GetKey(KeyCode.T) && devMode == false)
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
                        DevMode();
			// enable devmode
                        devMode = true;
                        timeLeft = 3f;
                        Debug.Log("DevMode activated");
                    }
                }
            }
        }
	}

    public void DevMode()
    {
        devMode = true;
        timeLeft = 3f;

        GameObject.Find("BG").GetComponent<Image>().sprite = devModeBG;
    }
}
