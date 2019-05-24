using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScaledPosition : MonoBehaviour {

    public Vector3 initialPosition;
    public CatManager catManager;

    private GameObject p1g;
    private GameObject p2g;

    private void Awake()
    {
        initialPosition = this.transform.position;

        if(GameObject.Find("CatManager") != null)
        {
            catManager = GameObject.Find("CatManager").GetComponent<CatManager>();
            p1g = catManager.p1g;
            p2g = catManager.p2g;
        }
        else
        {
            p1g = GameObject.Find("Sausage");
            p2g = GameObject.Find("Queso");
        }
    }

    // Use this for initialization
    void OnEnable () {
        this.transform.position = initialPosition;
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y * (((p1g.transform.localScale.x + p2g.transform.localScale.x)/2)*2), this.transform.position.x);

        if(this.GetComponent<RandomRatSpawn>() != null)
        {
            this.GetComponent<RandomRatSpawn>().randomSpawn();
        }
	}
}
