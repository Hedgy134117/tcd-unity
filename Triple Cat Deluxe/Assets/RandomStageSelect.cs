using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomStageSelect : MonoBehaviour {

    public StageManager stageManager;
    public List<GameObject> stageNames;
    public string randomStage;

    public GameObject preview;
    public List<Sprite> previews;
	
	public void randomStageSelect()
    {
        randomStage = stageNames[Random.Range(0, stageNames.Count)].gameObject.name;
        stageManager.stage = randomStage;
        randomStagePreview(previews);
    }

    public void randomStagePreview(List<Sprite> previews)
    {
        foreach (var previewImg in previews)
        {
            if (previewImg.name == randomStage)
            {
                preview.GetComponent<Image>().sprite = previewImg;
            }
        }
        
    }
}
