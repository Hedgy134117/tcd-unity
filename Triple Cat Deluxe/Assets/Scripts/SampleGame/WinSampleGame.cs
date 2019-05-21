using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinSampleGame : MonoBehaviour {

    [Header("Players")]
    public CatManager catManager;
    private GameObject p1;
    public Vector3 p1s;
    private GameObject p2;
    public Vector3 p2s;

    [Header("Cards")]
    public GameObject cardsManager;
    private CardsManager cardManager;

    private List<GameObject> cards;

    // Arrays of GameObjects to disable/enable
    [Header("Enable/Disable")]
    public GameObject[] toDisable;
    public GameObject[] toEnable;

    [Header("Game Assets")]
    public GameObject drawCardObject;

    public SpriteRenderer bg;
    public Sprite bgImage;

    public GameObject[] rats;

    public GameObject ceiling;

    public GameObject floor;
    public Vector3 floorPosition;
    public Vector3 floorScale;
    public Quaternion floorRotation;
    public StageManager stageManager;

    [Header("Other Assets")]
    public string winner;



    public void GetVariables()
    {
        cardManager = cardsManager.GetComponent<CardsManager>();
        cards = new List<GameObject>(cardManager.Cards);

        winner = "";

        if(GameObject.Find("CatManager") != null)
        {
            catManager = GameObject.Find("CatManager").GetComponent<CatManager>();
            p1 = catManager.p1g;
            p2 = catManager.p2g;
        }
        else
        {
            p1 = GameObject.Find("Sausage");
            p2 = GameObject.Find("Queso");
        }

        // get floor
        if (GameObject.Find("StageManager") != null)
        {
            stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
            floor = stageManager.currentStage;
        }

        p1s = p1.transform.localScale;
        p2s = p2.transform.localScale;
        floorScale = floor.transform.localScale;
        floorRotation = floor.transform.localRotation;
        floorPosition = floor.transform.localPosition;
    }

    // Update is called once per frame
    void Update () {
        check();
        resetGame();
	}

    void check()
    {
        // Runs while there is no winner
        if (winner == "")
        {
            // If the player is below the floor
            if (p1.transform.position.y <= floor.transform.position.y-2.12f)
            {
                winner = "P2";
                // look at all cards and see which one is the current one
                foreach (var card in cardManager.TotalCards)
                {
                    if (card.tag == "currentCard")
                    {
                        // give points
                        GameObject.Find("ScoreDisplay").GetComponent<scoreAndscoreDisplay>().P2score += card.gameObject.GetComponent<CardDisplay>().card.pointsToAdd;
                    }
                }
                
            }
            // if the player is p2, p1 wins
            else if (p2.transform.position.y <= floor.transform.position.y - 2.12f)
            {
                winner = "P1";
                // look at all cards and see which one is the current one
                foreach (var card in cardManager.TotalCards)
                {
                    if (card.tag == "currentCard")
                    {
                        // give points
                        GameObject.Find("ScoreDisplay").GetComponent<scoreAndscoreDisplay>().P1score += card.gameObject.GetComponent<CardDisplay>().card.pointsToAdd;
                    }
                }
            }
        }
    }

    void resetGame()
    {
        if(winner != "")
        {
            // look at all cards and see which one is the current one
            foreach (var card in cards.ToArray())
            {
                if (card.tag == "currentCard")
                {
                    // remove card from cards array(s)
                    cards.Remove(card);
                    drawCardObject.GetComponent<DrawCardScript>().Cards.Remove(card);
                    // reset that card's tag
                    card.tag = "Card";
                }
            }

            // toEnable/toDisable
            foreach (var item in toEnable)
            {
                item.SetActive(true);
            }
            foreach (var item in toDisable)
            {
                item.SetActive(false);
            }

            // kill all clones
            foreach (var clone in GameObject.FindGameObjectsWithTag("clone"))
            {
                Destroy(clone);
            }

            // reset Winner
            winner = "";

            // reset player Rotation and Size

            p1.transform.localScale = p1s;
            p2.transform.localScale = p2s;

            // reset player position
            p1.transform.position = new Vector3(Random.Range(-7f, 0f), 0.5f, 0f);
            p2.transform.position = new Vector3(Random.Range(1f, 7f), 0.5f, 0f);

            // reset player color
            p1.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            p2.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);

            // Reset Defaults
            normalReset();
        }
    }

    void normalReset()
    {
        // reset speed and jump height
        p1.GetComponent<PlayerOneMovement>().speed = 3f;
        p1.GetComponent<PlayerOneMovement>().jumpHeight = 6.25f;
        p2.GetComponent<PlayerTwoMovement>().speed = 3f;
        p2.GetComponent<PlayerTwoMovement>().jumpHeight = 6.25f;

        // reset flying
        p1.GetComponent<PlayerOneMovement>().flyingEnabled = false;
        p2.GetComponent<PlayerTwoMovement>().flyingEnabled = false;

        // reset gravity scale
        p1.GetComponent<Rigidbody2D>().gravityScale = 1f;
        p2.GetComponent<Rigidbody2D>().gravityScale = 1f;

        // reset floor scale and rotation and material
        floor.transform.localScale = floorScale;
        floor.transform.localRotation = floorRotation;
        floor.transform.localPosition = floorPosition;

        // reset bg
        bg.sprite = bgImage;

        // remove rats
        foreach (var rat in rats)
        {
            rat.SetActive(false);
        }

        // remove ceiling
        ceiling.SetActive(false);
    }

}
