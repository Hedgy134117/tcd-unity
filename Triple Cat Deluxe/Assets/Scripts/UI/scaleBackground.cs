using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleBackground : MonoBehaviour {

    public GameObject mainCamera;
	
	// Update is called once per frame
	void Update () {
	// scale the background by a specific size that looks good
        this.gameObject.transform.localScale = new Vector2(mainCamera.GetComponent<Camera>().orthographicSize * 1.02f, mainCamera.GetComponent<Camera>().orthographicSize * 0.48f);
    }
}
