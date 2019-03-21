using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class settingsLabels : MonoBehaviour {

    public AllSettings settings;
	
	void LateUpdate () {
        this.GetComponent<TMP_Text>().text = this.gameObject.GetComponentInParent<Slider>().value.ToString();

        if(this.transform.parent.CompareTag("modifier"))
        {
            this.GetComponent<TMP_Text>().text += "x";
        }
    }
}
