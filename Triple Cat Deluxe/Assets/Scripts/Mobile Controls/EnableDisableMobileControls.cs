using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableMobileControls : MonoBehaviour {

    public GameObject sampleGame;
    public GameObject controls;

    private void Start()
    {
        sampleGame = Resources.FindObjectsOfTypeAll<WinSampleGame>()[0].gameObject;
    }

    private void Update()
    {
        if (sampleGame.activeInHierarchy == true)
        {
            controls.SetActive(true);
        }
        else
        {
            controls.SetActive(false);
        }
    }
}
