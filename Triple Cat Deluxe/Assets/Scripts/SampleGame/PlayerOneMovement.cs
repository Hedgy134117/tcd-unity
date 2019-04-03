using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour {

    // variables
    public Rigidbody2D rb;
    public float jumpHeight = 6.25f;
    public float speed = 3f;

    private bool floored;

    public bool flyingEnabled;

    private void Awake()
    {
	// get rigidbody and set flying to false
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        flyingEnabled = false;
    }

    // Update is called once per frame
    void Update () {
	// movement
	// checks if floored so cat can jump
	// or if flying is enabled then allow infinite jumps
	if(Input.GetKeyDown("w") && floored == true && flyingEnabled == false)
        {
            rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            floored = false;
        }
        else if(Input.GetKeyDown("w") && flyingEnabled == true)
        {
            rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
        }
        if(Input.GetKeyDown("a"))
        {
            rb.AddForce(new Vector2(-speed, 0), ForceMode2D.Impulse);

            // check if cat is facing left or right and change their looks based on it
            switch (this.gameObject.name)
            {
                case "Sausage":
                    if (transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Queso":
                    if (transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Canada":
                    if (transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "JohnJonJean":
                    if (transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Owo":
                    if (transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Jupiter":
                    if (transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Gwendoline":
                    if(transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Igor":
                    if(transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Texas":
                    if(transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Washington":
                    if(transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Qwerty":
                    if(transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Toothpick":
                    if(transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;
            }
        }
        if(Input.GetKeyDown("d"))
        {
            rb.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);

            // check if cat is facing left or right and change their looks based on it
            switch (this.gameObject.name)
            {
                case "Sausage":
                    if (transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Queso":
                    if (transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Canada":
                    if (transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "JohnJonJean":
                    if (transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Owo":
                    if (transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Jupiter":
                    if (transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Gwendoline":
                    if (transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Igor":
                    if (transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Texas":
                    if (transform.localScale.x < 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Washington":
                    if (transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Qwerty":
                    if (transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;

                case "Toothpick":
                    if (transform.localScale.x > 0)
                    {
                        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                    }
                    break;
            }
        }
        if(Input.GetKeyDown("s"))
        {
            rb.AddForce(new Vector2(0, -jumpHeight), ForceMode2D.Impulse);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            floored = true;
        } 
    }
}
