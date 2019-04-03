using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class settingsLabels : MonoBehaviour {

    // variables
    public AllSettings settings;
	
    void LateUpdate () {
	// the text is equal to the value of the slider
        this.GetComponent<TMP_Text>().text = this.gameObject.GetComponentInParent<Slider>().value.ToString();

	// if it is a modifier then add an x to the end of the value (indicating that it is a multiplier)
        if(this.transform.parent.CompareTag("modifier"))
        {
            this.GetComponent<TMP_Text>().text += "x";
        }
    }
}
