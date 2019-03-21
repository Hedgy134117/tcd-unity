using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class developerMode : MonoBehaviour {

    public float timeLeft = 3f;
    public bool devMode = false;

	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.T) && devMode == false)
        {
            Debug.Log("t");
            if (Input.GetKey(KeyCode.C) && devMode == false)
            {
                Debug.Log("c");
                if (Input.GetKey(KeyCode.D) && devMode == false)
                {
                    Debug.Log("d");
                    timeLeft -= Time.deltaTime;

                    if (timeLeft <= 0f)
                    {
                        devMode = true;
                        timeLeft = 3f;
                        Debug.Log("DevMode activated");
                    }
                }
            }
        }
	}
}
