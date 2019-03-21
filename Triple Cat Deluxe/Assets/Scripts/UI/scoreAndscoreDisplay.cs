using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreAndscoreDisplay : MonoBehaviour {

    public int P1score;
    public int P2score;

    public TMP_Text text;
	
	// Update is called once per frame
	void Update () {
        text.text = P1score + " : " + P2score;
	}
}
