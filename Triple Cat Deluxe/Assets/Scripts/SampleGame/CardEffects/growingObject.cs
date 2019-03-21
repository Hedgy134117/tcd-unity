using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growingObject : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Transform>().localScale += new Vector3(0.01f, 0.01f, 0.01f);
	}
}
