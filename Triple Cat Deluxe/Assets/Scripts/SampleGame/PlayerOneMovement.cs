using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour {

    // variables
    public Rigidbody2D rb;
    public float jumpHeight = 6.25f;
    public float speed = 3f;

    public bool floored;

    public bool flyingEnabled;

    private void Awake()
    {
	    // get rigidbody and set flying to false
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        flyingEnabled = false;
    }

    public void Jump(GameObject cat)
    {
        cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
        floored = false;
    }

    public void Fly(GameObject cat)
    {
        cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
    }

    public void Left(GameObject cat)
    {
        cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0), ForceMode2D.Impulse);

        // check if cat is facing left or right and change their looks based on it
        switch (cat.name)
        {
            case "Sausage":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Queso":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Canada":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "JohnJonJean":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Owo":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Jupiter":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Gwendoline":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Igor":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Texas":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Washington":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Qwerty":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Toothpick":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;
        }
    }

    public void Right(GameObject cat)
    {
        cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);

        // check if cat is facing left or right and change their looks based on it
        switch (cat.name)
        {
            case "Sausage":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Queso":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Canada":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "JohnJonJean":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Owo":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Jupiter":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Gwendoline":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Igor":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Texas":
                if (cat.transform.localScale.x < 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Washington":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Qwerty":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;

            case "Toothpick":
                if (cat.transform.localScale.x > 0)
                {
                    transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
                }
                break;
        }
    }

    public void Down(GameObject cat)
    {
        cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -jumpHeight), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update () {
	    // movement
	    // checks if floored so cat can jump
	    // or if flying is enabled then allow infinite jumps
	    if(Input.GetKeyDown("w") && floored == true && flyingEnabled == false)
        {
            Jump(this.gameObject);
        }
        else if(Input.GetKeyDown("w") && flyingEnabled == true)
        {
            Fly(this.gameObject);
        }
        if(Input.GetKeyDown("a"))
        {
            Left(this.gameObject);
        }
        if(Input.GetKeyDown("d"))
        {
            Right(this.gameObject);
        }
        if(Input.GetKeyDown("s"))
        {
            Down(this.gameObject);
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
