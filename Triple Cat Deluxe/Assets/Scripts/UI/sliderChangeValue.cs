using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderChangeValue : MonoBehaviour {

    public AllSettings settings;

	public void Update()
    {
        this.gameObject.GetComponent<Slider>().value = (float)System.Math.Round((double)this.gameObject.GetComponent<Slider>().value, 1);

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
