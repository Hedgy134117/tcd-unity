using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StageDisplay : MonoBehaviour {

    private StageManager stageManager;

    private void Start()
    {
        stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
    }

    private void Update()
    {
        this.GetComponent<TMP_Text>().text = stageManager.stage;
    }
}
