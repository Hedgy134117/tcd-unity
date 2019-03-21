using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour {

    public string p1;
    public string p2;

    public GameObject p1g;
    public GameObject p2g;

    public List<GameObject> cats;
    public catIdentifier[] cats2 = new catIdentifier[12];
    public CatSelect catSelect;

    public void Update()
    {
        if(GameObject.Find("SampleScene") != null)
        {
            cats2 = Resources.FindObjectsOfTypeAll<catIdentifier>();

            foreach (var cat in cats2)
            {
                if (cat.gameObject.name == p1)
                {
                    cat.tag = "currentp1";
                    p1g = cat.gameObject;
                }
                else if (cat.gameObject.name == p2)
                {
                    cat.tag = "currentp2";
                    p2g = cat.gameObject;
                }
                else
                {
                    cat.tag = "Untagged";
                }

                if(cats.Count != 12)
                {
                    cats.Add(cat.gameObject);
                }
                
            }
        }
        
    }

}
