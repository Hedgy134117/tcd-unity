using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingFloor : MonoBehaviour {

    public float sizeToShrinkBy;

    public List<GameObject> triplePlatforms;

    // Update is called once per frame
    void Update () {
        switch(this.gameObject.name)
        {
            case "Rectangular":
                // if the scale of the floor is greater than or equal to 0.01 then shrink the floor
                if (transform.localScale.x >= 0.01f)
                {
                    transform.localScale -= new Vector3(sizeToShrinkBy, 0f, 0f);
                }
                // otherwise rotate the floor
                else
                {
                    transform.Rotate(Vector3.one);
                }
                break;

            case "SemiCircle":
                // rotate and shrink
                if(transform.localScale.x >= 0.01f)
                {
                    transform.localScale -= new Vector3(sizeToShrinkBy, 0f, 0f);
                }
                transform.Rotate(new Vector3(0, 0, 0.5f));
                break;

            case "Triangular":
                // smaller on y bigger on x
                if(transform.localScale.x >= 0.01f)
                {
                    transform.localScale -= new Vector3(sizeToShrinkBy, 0f, 0f);
                    transform.localScale += new Vector3(0f, sizeToShrinkBy, 0f);
                }
                break;
            case "Triple Platforms":
                foreach (var platform in triplePlatforms)
                {
                    // if the scale of the floor is greater than or equal to 0.01 then shrink the floor
                    if (platform.transform.localScale.x >= 0.01f)
                    {
                        platform.transform.localScale -= new Vector3(sizeToShrinkBy, 0f, 0f);
                    }
                    // otherwise rotate the floor
                    else
                    {
                        platform.transform.Rotate(Vector3.one);
                    }
                }
                break;
        }
        
    }
}
