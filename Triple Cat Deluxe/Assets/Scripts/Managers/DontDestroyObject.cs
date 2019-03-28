using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObject : MonoBehaviour {

    public GameObject[] objects;

	// Use this for initialization
	void Start () {
	// do not destroy any objects on a new scene load in the objects array
        foreach (var item in objects)
        {
            DontDestroyOnLoad(item);
        }
	}
}
