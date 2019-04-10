using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinManager : MonoBehaviour {

    // variables
    public GameObject canvas;

    [Header("Managers")]
    public scoreAndscoreDisplay scoreManager;
    public DrawCardScript drawCard;
    public CatManager catManager;

    [Header("Win Screens")]
    public GameObject sausage;
    public GameObject queso;
    public GameObject canada;
    public GameObject johnjonjean;
    public GameObject owo;
    public GameObject jupiter;
    public GameObject gwendoline;
    public GameObject igor;
    public GameObject texas;
    public GameObject washington;
    public GameObject qwerty;
    public GameObject toothpick;

    [Header("Players")]
    public GameObject p1;
    public GameObject p2;

    [Header("Settings")]
    private AllSettings settings;
    public int pointsToWin;

    [Header("Misc")]
    public GameObject creditsButton;

    [Header ("DEBUG")]
    public string winner;

    private void LateUpdate()
    {
	// get managers
        if (GameObject.Find("SettingsManager") != null && GameObject.Find("DevModeManager").GetComponent<developerMode>().devMode == false)
        {
            settings = GameObject.Find("SettingsManager").GetComponent<AllSettings>();
            pointsToWin = settings.pointsToWin;
        }

        if (GameObject.Find("CatManager") != null)
        {
            catManager = GameObject.Find("CatManager").GetComponent<CatManager>();
            p1 = catManager.p1g;
            p2 = catManager.p2g;
        }
        else if (GameObject.Find("Sausage") != null)
        {
            p1 = GameObject.Find("Sausage");
            p2 = GameObject.Find("Queso");
        }
    }

    // Update is called once per frame
    void Update () {

        // Check when all cards are used
        if (scoreManager.P1score >= pointsToWin || scoreManager.P2score >= pointsToWin || winner != "")
        {
            // enable winnerCanvas
            canvas.SetActive(true);

	    // if p1 wins then set the win screen to their cat
            if(scoreManager.P1score >= pointsToWin)
            {
                switch(p1.name)
                {
                    case "Sausage":
                        sausage.SetActive(true);
                        break;

                    case "Queso":
                        queso.SetActive(true);
                        break;

                    case "Canada":
                        canada.SetActive(true);
                        break;

                    case "JohnJonJean":
                        johnjonjean.SetActive(true);
                        break;

                    case "Owo":
                        owo.SetActive(true);
                        break;

                    case "Jupiter":
                        jupiter.SetActive(true);
                        break;

                    case "Gwendoline":
                        gwendoline.SetActive(true);
                        break;

                    case "Igor":
                        igor.SetActive(true);
                        break;

                    case "Texas":
                        texas.SetActive(true);
                        break;

                    case "Washington":
                        washington.SetActive(true);
                        break;

                    case "Qwerty":
                        qwerty.SetActive(true);
                        break;

                    case "Toothpick":
                        toothpick.SetActive(true);
                        break;
                }
            }
	    // if p2 wins then set the win screen to their cat
            else if(scoreManager.P2score >= pointsToWin) 
            {
                switch (p2.name)
                {
                    case "Sausage":
                        sausage.SetActive(true);
                        break;

                    case "Queso":
                        queso.SetActive(true);
                        break;

                    case "Canada":
                        canada.SetActive(true);
                        break;

                    case "JohnJonJean":
                        johnjonjean.SetActive(true);
                        break;

                    case "Owo":
                        owo.SetActive(true);
                        break;

                    case "Jupiter":
                        jupiter.SetActive(true);
                        break;

                    case "Gwendoline":
                        gwendoline.SetActive(true);
                        break;

                    case "Igor":
                        igor.SetActive(true);
                        break;

                    case "Texas":
                        texas.SetActive(true);
                        break;

                    case "Washington":
                        washington.SetActive(true);
                        break;

                    case "Qwerty":
                        qwerty.SetActive(true);
                        break;

                    case "Toothpick":
                        toothpick.SetActive(true);
                        break;
                }
            }
		
	    // enable the back to start or credits button
            creditsButton.SetActive(true);
        }
	}
}
