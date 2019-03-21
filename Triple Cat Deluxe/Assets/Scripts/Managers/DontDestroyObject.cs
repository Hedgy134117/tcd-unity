using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObject : MonoBehaviour {

    public GameObject[] objects;

	// Use this for initialization
	void Start () {
        foreach (var item in objects)
        {
            DontDestroyOnLoad(item);
        }
	}
}
