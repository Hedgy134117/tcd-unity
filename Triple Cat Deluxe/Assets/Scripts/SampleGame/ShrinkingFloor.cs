using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingFloor : MonoBehaviour {

    public float sizeToShrinkBy;

    // Update is called once per frame
    void Update () {
	// if the scale of the floor is greater than or equal to 0.01 then shrink the floor
        if (transform.localScale.x >= 0.01f)
        {
            transform.localScale -= new Vector3(sizeToShrinkBy, 0f, 0f);
        } 
	// otherwise rotate the floor
	else
        {
            transform.Rotate(Vector3.one);
        }
    }
}
