using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMovingCamera : MonoBehaviour {

    public GameObject sampleGame;

    private AllSettings settings;
    public bool dynamicCamera;

    private void Start()
    {
        if(GameObject.Find("SettingsManager") != null)
        {
            settings = GameObject.Find("SettingsManager").GetComponent<AllSettings>();
            dynamicCamera = settings.dynamicCamera;
        }
    }

    void Update () {
        if(dynamicCamera)
        {
            if (sampleGame.activeInHierarchy == true && this.GetComponent<MovingCamera>() == false)
            {
                this.gameObject.AddComponent<MovingCamera>();
            }
            else if (sampleGame.activeInHierarchy == false && this.GetComponent<MovingCamera>() == true)
            {
                Destroy(this.GetComponent<MovingCamera>());
            }
        }
		
	}
}
