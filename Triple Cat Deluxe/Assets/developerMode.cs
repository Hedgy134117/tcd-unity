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
        {
            if (Input.GetKey(KeyCode.C) && devMode == false && SceneManager.GetActiveScene().buildIndex == 0)
            {
                if (Input.GetKey(KeyCode.D) && devMode == false && SceneManager.GetActiveScene().buildIndex == 0)
                {
                    timeLeft -= Time.deltaTime;

                    if (timeLeft <= 0f)
                    {
                        DevMode();
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
