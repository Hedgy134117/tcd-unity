using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour {

    public string stage;

    public FloorIdentifier[] floorIdentifiers;

    public GameObject currentStage;

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "SampleScene")
        {
            floorIdentifiers = Resources.FindObjectsOfTypeAll<FloorIdentifier>();

            foreach (var floor in floorIdentifiers)
            {
                if(floor.gameObject.name == stage)
                {
                    currentStage = floor.gameObject;
                }
            }
        }
    }

}
