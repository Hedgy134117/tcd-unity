using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCollisionDetector : MonoBehaviour {

    public GameObject collisionParticles;

    public float velocityGreaterThan;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "currentp2" || collision.gameObject.tag == "currentp1")
        {
            if (Mathf.Abs(this.gameObject.GetComponent<Rigidbody2D>().velocity.x) > velocityGreaterThan)
            {
                Instantiate(collisionParticles, this.gameObject.transform.position, new Quaternion(-180f, 0f, 0f, 0f));
            }
        }
    }
}
