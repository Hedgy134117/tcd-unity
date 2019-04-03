using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderChangeValue : MonoBehaviour {

    // variables
    public AllSettings settings;

    public void Update()
    {
	// round the value to 2 decimals
        this.gameObject.GetComponent<Slider>().value = (float)System.Math.Round((double)this.gameObject.GetComponent<Slider>().value, 1);

	// set the settings value to the value of this object
        switch(this.gameObject.name)
        {
            case "PTW slider":
                settings.pointsToWin = (int)this.gameObject.GetComponent<Slider>().value;
                break;

            case "CSI slider":
                settings.catSize = this.gameObject.GetComponent<Slider>().value;
                break;

            case "CSP slider":
                settings.catSpeed = this.gameObject.GetComponent<Slider>().value;
                break;

            case "CJU slider":
                settings.catJumps = this.gameObject.GetComponent<Slider>().value;
                break;
        }
    }
}
