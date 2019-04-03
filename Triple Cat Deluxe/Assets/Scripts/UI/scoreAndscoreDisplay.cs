using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreAndscoreDisplay : MonoBehaviour {

    // variables
    public int P1score;
    public int P2score;

    public TMP_Text text;
	
	// Update is called once per frame
	void Update () {
	// the display of the score is P1score : P2score
        text.text = P1score + " : " + P2score;
	}
}
