using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour {

    public CatManager catManager;

    public GameObject sausage;
    public GameObject queso;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        if (GameObject.Find("CatManager") != null)
        {
            catManager = GameObject.Find("CatManager").GetComponent<CatManager>();

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

        this.GetComponent<WinSampleGame>().catManager = catManager;
        this.GetComponent<WinSampleGame>().GetVariables();
        this.GetComponent<applyMinor>().catManager = catManager;
        this.GetComponent<applyMinor>()._ApplyMinor();
        this.GetComponent<ApplyModifiers>().catManager = catManager;
        this.GetComponent<ApplyModifiers>().applyModifiers();
        this.GetComponent<WinSampleGame>().catManager = catManager;
    }
}
