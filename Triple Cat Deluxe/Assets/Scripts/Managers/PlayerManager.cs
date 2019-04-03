using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour {

    // variables
    public CatManager catManager;

    public GameObject sausage;
    public GameObject queso;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        // if cat manager exists
        if (GameObject.Find("CatManager") != null)
        {
            catManager = GameObject.Find("CatManager").GetComponent<CatManager>();

            // get player one and player 2
            // if needed add the playerOneMovement script
            // enable the cats on the enable of sample game
            foreach (var cat in catManager.cats)
            {
                if (cat.tag == "currentp1")
                {
                    if(cat.GetComponent<PlayerOneMovement>() == null)
                    {
                        cat.AddComponent<PlayerOneMovement>();
                    }
                    cat.gameObject.SetActive(true);
                }
                if (cat.tag == "currentp2")
                {
                    if (cat.GetComponent<PlayerTwoMovement>() == null)
                    {
                        cat.AddComponent<PlayerTwoMovement>();
                    }
                    cat.gameObject.SetActive(true);
                }
            }
        } 
        // otherwise make p1/p2 sausage/queso
        else
        {
            if (sausage.GetComponent<PlayerOneMovement>() == null)
            {
                sausage.AddComponent<PlayerOneMovement>();
            }
            sausage.SetActive(true);
            if (queso.GetComponent<PlayerTwoMovement>() == null)
            {
                queso.AddComponent<PlayerTwoMovement>();
            }
            queso.SetActive(true);
        }

        // make each scripts catmanager equal to this catmanager and run their functions
        // this is needed because the scripts weren't able to find catmanager
        this.GetComponent<WinSampleGame>().catManager = catManager;
        this.GetComponent<WinSampleGame>().GetVariables();
        this.GetComponent<applyMinor>().catManager = catManager;
        this.GetComponent<applyMinor>()._ApplyMinor();
        this.GetComponent<ApplyModifiers>().catManager = catManager;
        this.GetComponent<ApplyModifiers>().applyModifiers();
        this.GetComponent<WinSampleGame>().catManager = catManager;
    }
}
