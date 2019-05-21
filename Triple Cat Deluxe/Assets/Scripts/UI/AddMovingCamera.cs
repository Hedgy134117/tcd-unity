using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMovingCamera : MonoBehaviour {

    // variables
    public GameObject sampleGame;

    private AllSettings settings;
    public bool dynamicCamera;
    public GameObject floor;


    private void Start()
    {
	// get settings
        if(GameObject.Find("SettingsManager") != null)
        {
            settings = GameObject.Find("SettingsManager").GetComponent<AllSettings>();
            dynamicCamera = settings.dynamicCamera;
        }
    }

    void Update () {
	// if dynamic camera is active from settings
        if(dynamicCamera)
        {
	    // if samplegame is active and this object doesn't have moving camera then add moving camera
            if (sampleGame.activeInHierarchy == true && this.GetComponent<MovingCamera>() == false)
            {
                this.gameObject.AddComponent<MovingCamera>();

                if (GameObject.Find("StageManager") == null)
                {
                    this.gameObject.GetComponent<MovingCamera>().floor = this.floor;
                }
            }
	    // if samplegame is not active and this object does have moving camera then delete moving camera
	    // (this is because the camera won't be able to find the cats)
            else if (sampleGame.activeInHierarchy == false && this.GetComponent<MovingCamera>() == true)
            {
                Destroy(this.GetComponent<MovingCamera>());
            }
        }
		
	}
}
