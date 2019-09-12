using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoDrawToggle : MonoBehaviour {

    public GameObject pickupCard;

	// Update is called once per frame
	public void Update () {
		if (this.GetComponent<Toggle>().isOn && pickupCard.GetComponent<Button>().IsInteractable() == true)
        {
            pickupCard.GetComponent<Button>().onClick.Invoke();
        }
	}
}
