using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour {

    // the name of p1 & p2
    // this is needed because cat selection is on a seperate scene. it gets the names of p1 and p2 
    public string p1;
    public string p2;

    // the actual game object p1 and p2
    public GameObject p1g;
    public GameObject p2g;

    // all cats
    public List<GameObject> cats;
    // all game object cats
    public catIdentifier[] cats2 = new catIdentifier[12];
    public CatSelect catSelect;

    public void Update()
    {
        // if the current scene is the arena
        if(GameObject.Find("SampleScene") != null)
        {
            // find every cat
            cats2 = Resources.FindObjectsOfTypeAll<catIdentifier>();

            // look at each cat
            foreach (var cat in cats2)
            {
                // if the actual gameobject cat p1 is equal to the name of p1
                if (cat.gameObject.name == p1)
                {
                    // make the gameobject p1
                    cat.tag = "currentp1";
                    p1g = cat.gameObject;
                }
                // if the actual gameobject cat p1 is equal to the name of p2
                else if (cat.gameObject.name == p2)
                {
                    // make the gameobject p2
                    cat.tag = "currentp2";
                    p2g = cat.gameObject;
                }
                // every other cat should not have a tag
                else
                {
                    cat.tag = "Untagged";
                }

                // if the amount of cats is not over 12, then add cat from cats2 to cats
                // 12 will change is more cats are added
                if(cats.Count != 12)
                {
                    cats.Add(cat.gameObject);
                }
                
            }
        }
        
    }

}
