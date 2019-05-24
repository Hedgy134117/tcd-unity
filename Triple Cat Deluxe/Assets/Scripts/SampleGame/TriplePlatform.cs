using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriplePlatform : MonoBehaviour {

    private void Start()
    {
        this.GetComponentInParent<ShrinkingFloor>().triplePlatforms.Add(this.gameObject);
    }

}
