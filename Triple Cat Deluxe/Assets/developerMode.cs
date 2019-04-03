using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class developerMode : MonoBehaviour {

    public float timeLeft = 3f;
    public bool devMode = false;

	// Update is called once per frame
	void Update () {

	// check if player is holding down T C D keys	
        if (Input.GetKey(KeyCode.T) && devMode == false)
        {
            Debug.Log("t");
            if (Input.GetKey(KeyCode.C) && devMode == false)
            {
                Debug.Log("c");
                if (Input.GetKey(KeyCode.D) && devMode == false)
                {
		    // start 3 second timer
                    Debug.Log("d");
                    timeLeft -= Time.deltaTime;

                    if (timeLeft <= 0f)
                    {
			// enable devmode
                        devMode = true;
                        timeLeft = 3f;
                        Debug.Log("DevMode activated");
                    }
                }
            }
        }
	}
}
