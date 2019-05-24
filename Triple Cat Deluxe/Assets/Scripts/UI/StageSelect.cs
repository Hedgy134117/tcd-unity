using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour {

    private StageManager stageManager;

    private void Start()
    {
        stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    public void selectStage()
    {
        stageManager.stage = this.gameObject.name;
    }
}
