using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StagePreview : MonoBehaviour {

    private GameObject preview;

	public void stagePreview(Sprite image)
    {
        preview = GameObject.Find("Stage Preview");

        preview.gameObject.GetComponent<Image>().sprite = image;
    }

}
