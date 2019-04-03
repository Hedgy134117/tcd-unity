using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growingObject : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	// grow by 0.01 every frame on every axis
        this.GetComponent<Transform>().localScale += new Vector3(0.01f, 0.01f, 0.01f);
	}
}
