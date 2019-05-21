using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorWake : MonoBehaviour {

    public GameObject floor;

	// Update is called once per frame
	void Start () {
		if(GameObject.Find("StageManager") == null)
        {
            floor.SetActive(true);
        }
        else if(GameObject.Find("StageManager") != null)
        {
            GameObject.Find("StageManager").GetComponent<StageManager>().currentStage.SetActive(true);
        }
	}
}
