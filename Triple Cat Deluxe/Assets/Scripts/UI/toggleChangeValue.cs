using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleChangeValue : MonoBehaviour {

    public AllSettings settings;

    public void changeValue()
    {
        switch (this.gameObject.name)
        {
            case "ThP toggle":
                settings.thinPlatform = this.gameObject.GetComponent<Toggle>().isOn;
                break;

            case "DyC toggle":
                settings.dynamicCamera = this.gameObject.GetComponent<Toggle>().isOn;
                break;
        }
    }

}
