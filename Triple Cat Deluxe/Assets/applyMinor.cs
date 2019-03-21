using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyMinor : MonoBehaviour {

    public CatManager catManager;

    private bool isApplied;

    public List<GameObject> cats;

    public GameObject sausage;
    public GameObject queso;

    [Header("These are multipliers, NOT actual values")]
    public float sausageSpeed;
    public float sausageJump;
    public float quesoSpeed;
    public float quesoJump;
    public float jjjSpeed;
    public float jjjJump;
    public float owoSpeed;
    public float owoJump;
    public float jupiterSpeed;
    public float jupiterJump;
    public float gwendolineSpeed;
    public float gwendolineJump;
    public float igorSpeed;
    public float igorJump;
    public float texasSpeed;
    public float texasJump;
    public float washingtonSpeed;
    public float washingtonJump;
    public float qwertySpeed;
    public float qwertyJump;
    public float toothpickSpeed;
    public float toothpickJump;

    public void _ApplyMinor()
    {
        if (GameObject.Find("CatManager") != null)
        {
            catManager = GameObject.Find("CatManager").GetComponent<CatManager>();
            cats = catManager.cats;
        }

        isApplied = false;
        if(isApplied == false)
        {
            foreach (var cat in cats)
            {
                switch (cat.name)
                {
                    case "Sausage":
                        // faster vertically
                        ApplyMinor(sausageSpeed, sausageJump, cat);
                        break;

                    case "Queso":
                        // a little slower all around
                        ApplyMinor(quesoSpeed, quesoJump, cat);
                        break;

                    case "JohnJonJean":
                        // a little slower all around
                        ApplyMinor(jjjSpeed, jjjJump, cat);
                        break;

                    case "OwO":
                        // a little faster all around
                        ApplyMinor(owoSpeed, owoJump, cat);
                        break;

                    case "Jupiter":
                        // higher jumps
                        ApplyMinor(jupiterSpeed, jupiterJump, cat);
                        break;

                    case "Gwendoline":
                        // same as now
                        ApplyMinor(gwendolineSpeed, gwendolineJump, cat);
                        break;

                    case "Igor":
                        // higher jumps
                        ApplyMinor(igorSpeed, igorJump, cat);
                        break;

                    case "Texas":
                        ApplyMinor(texasSpeed, texasJump, cat);
                        // higher jumps
                        break;

                    case "Washington":
                        // a little faster all around
                        ApplyMinor(washingtonSpeed, washingtonJump, cat);
                        break;

                    case "Qwerty":
                        // super fast all around
                        ApplyMinor(qwertySpeed, qwertyJump, cat);
                        break;

                    case "Toothpick":
                        // same as now
                        ApplyMinor(toothpickSpeed, toothpickJump, cat);
                        break;
                }
            }
        }
        isApplied = true;
    }

    public void ApplyMinor(float mod1, float mod2, GameObject cat)
    {
        if (cat.gameObject.tag == "currentp1")
        {
            cat.gameObject.GetComponent<PlayerOneMovement>().speed *= mod1;
            cat.gameObject.GetComponent<PlayerOneMovement>().jumpHeight *= mod2;
        }
        else if (cat.gameObject.tag == "currentp2")
        {
            cat.gameObject.GetComponent<PlayerTwoMovement>().speed *= mod1;
            cat.gameObject.GetComponent<PlayerTwoMovement>().jumpHeight *= mod2;
        }
    }

}
