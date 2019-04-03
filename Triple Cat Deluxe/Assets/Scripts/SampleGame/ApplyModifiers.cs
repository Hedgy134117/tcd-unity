using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyModifiers : MonoBehaviour {

    private AllSettings settings;
    public CatManager catManager;
    private GameObject p1;
    private GameObject p2;
    public GameObject sausage;
    public GameObject queso;
    public GameObject floor;

    [Header("Modifiers")]
    public float catSize;
    public float catSpeed;
    public float catJumps;
    public bool thinPlatform;

    public void applyModifiers()
    {
        // get settings and cats
        if (GameObject.Find("SettingsManager") != null)
        {
            settings = GameObject.Find("SettingsManager").GetComponent<AllSettings>();

            catSize = settings.catSize;
            catSpeed = settings.catSpeed;
            catJumps = settings.catJumps;
            thinPlatform = settings.thinPlatform;
        }
        else
        {
            catSize = 1f;
            catSpeed = 1f;
            catJumps = 1f;
        }

        if (GameObject.Find("CatManager") != null)
        {
            catManager = GameObject.Find("CatManager").GetComponent<CatManager>();
            p1 = catManager.p1g;
            p2 = catManager.p2g;
        }
        else
        {
            p1 = sausage;
            p2 = queso;
        }

        // multiply cats size by modifier
        p1.transform.localScale *= catSize;
        p2.transform.localScale *= catSize;

        // multiply cats speed by modifier
        p1.GetComponent<PlayerOneMovement>().speed *= catSpeed;
        p2.GetComponent<PlayerTwoMovement>().speed *= catSpeed;

        // multiply cats jumps by modifer
        p1.GetComponent<PlayerOneMovement>().jumpHeight *= catJumps;
        p2.GetComponent<PlayerTwoMovement>().jumpHeight *= catJumps;

        // if thinplatform is true then make the platform 1/4x the thickness
        if (thinPlatform)
        {
            floor.transform.localScale = new Vector3(floor.transform.localScale.x, floor.transform.localScale.y * 0.25f, floor.transform.localScale.z);
        }
    }
}
