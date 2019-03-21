using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffectsManager : MonoBehaviour {

    // get cards
    [Header("Managers")]
    public GameObject cardManager;
    private List<GameObject> cards;

    public CatManager catManager;
    private GameObject p1;
    private GameObject p2;

    public bool effectApplied;

    [Header("Effect Values")]
    public float meowSpeed;
    public float meowAmount;

    [Header("SampleGame Assets")]
    public GameObject floor;

    [Header("Other Assets")]
    public GameObject ratsHolder;
    public GameObject[] rats;

    public GameObject ceilingHolder;
    public GameObject ceilingObject;

    public SpriteRenderer bg;
    public Sprite happyHopeBg;

    public GameObject godsCat;

    public GameObject jimmy;

    public PhysicsMaterial2D slippyMaterial;

    public GameObject texasRodeo;

    public GameObject studiousSam;

    public GameObject kittyKorner;

    public GameObject cowboy;

    void Start()
    {
        cards = cardManager.GetComponent<CardsManager>().Cards;

        if (GameObject.Find("CatManager") != null)
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
    }

    private void OnEnable()
    {
        effectApplied = false;
    }

    void Update()
    {

        foreach (var card in cards)
        {
            if (card.tag == "currentCard")
            {
                applyEffect(card.name);
            }
        }

    }

    void applyEffect(string effect)
    {
        if(effectApplied == false)
        {
            switch (effect)
            {
                case "The Absolute Stronk":
                    p1.transform.localScale *= 2;
                    p2.transform.localScale *= 2;
                    effectApplied = true;
                    break;

                case "Jimmy Jr.":
                    ratsHolder.SetActive(true);
                    foreach (var rat in rats)
                    {
                        rat.SetActive(true);
                    }
                    effectApplied = true;
                    break;

                case "Sickly Mickly":
                    p1.GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 0f);
                    p2.GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 0f);

                    effectApplied = true;
                    break;

                case "meOW":
                    // Mathf.Sin(Time.time * speed) * amount
                    // speed - how fast it shakes
                    // amount - how much it shakes
                    floor.transform.position = new Vector3((Mathf.Sin(Time.time * meowSpeed) * meowAmount), (Mathf.Sin(Time.time * -meowSpeed) * -meowAmount)-2.88f, 0f);
                    break;

                case "Rocky (alias)":
                    p1.GetComponent<PlayerOneMovement>().flyingEnabled = true;
                    p2.GetComponent<PlayerTwoMovement>().flyingEnabled = true;

                    p1.GetComponent<Rigidbody2D>().gravityScale += 0.01f;
                    p2.GetComponent<Rigidbody2D>().gravityScale += 0.01f;
                    break;

                case "Borf":
                    // Nothing Happens
                    break;

                case "You are nothing":
                    p1.transform.localScale *= 0.5f;
                    p2.transform.localScale *= 0.5f;
                    effectApplied = true;
                    break;

                case "Fwuffy":
                    ceilingHolder.SetActive(true);
                    ceilingObject.SetActive(true);
                    effectApplied = true;
                    break;

                case "Fwuffy Jr.":
                    if (floor.transform.position.y < 3)
                    {
                        floor.transform.position += new Vector3(0f, 0.01f, 0f);
                    }
                    else
                    {
                        effectApplied = true;
                    }
                    break;

                case "Pablo":
                    //
                    break;

                case "Back Alley Christmas Lights":
                    p1.GetComponent<PlayerOneMovement>().speed *= 2;
                    p1.GetComponent<PlayerOneMovement>().jumpHeight *= 2;
                    p2.GetComponent<PlayerTwoMovement>().speed *= 2;
                    p2.GetComponent<PlayerTwoMovement>().jumpHeight *= 2;
                    effectApplied = true;
                    break;

                case "God's Cat":
                    godsCat.SetActive(true);

                    effectApplied = true;
                    break;

                case "Jimmy":
                    jimmy.SetActive(true);

                    effectApplied = true;
                    break;

                case "Scrub a Dub Tub":
                    floor.GetComponent<BoxCollider2D>().sharedMaterial = slippyMaterial;

                    effectApplied = true;
                    break;

                case "Luffy the Kitten Hunter":
                    //
                    break;

                case "A sad man":
                    p1.GetComponent<PlayerOneMovement>().speed *= 0.25f;
                    p2.GetComponent<PlayerTwoMovement>().speed *= 0.25f;
                    effectApplied = true;
                    break;

                case "Texas Rodeo":
                    texasRodeo.SetActive(true);

                    effectApplied = true;
                    break;

                case "Happy Hope":
                    bg.sprite = happyHopeBg;
                    effectApplied = true;
                    break;

                case "Poppy Poor":
                    p1.transform.localScale = new Vector3(p1.transform.localScale.x * 0.75f, p1.transform.localScale.y, p1.transform.localScale.z);
                    p2.transform.localScale = new Vector3(p2.transform.localScale.x * 0.75f, p2.transform.localScale.y, p2.transform.localScale.z);
                    effectApplied = true;
                    break;

                case "Studious Sam":
                    studiousSam.SetActive(true);

                    effectApplied = true;
                    break;

                case "Kitty Korner":
                    kittyKorner.SetActive(true);

                    effectApplied = true;
                    break;

                case "A Cat that Just Yawns":
                    p1.GetComponent<PlayerOneMovement>().speed *= 0.5f;
                    p2.GetComponent<PlayerTwoMovement>().speed *= 0.5f;
                    effectApplied = true;
                    break;

                case "Cheesey Wheesey":
                    //
                    break;

                case "Nice Kitty":
                    p1.transform.position = Vector3.MoveTowards(p1.transform.position, p2.transform.position, 0.05f);
                    p2.transform.position = Vector3.MoveTowards(p2.transform.position, p1.transform.position, 0.05f);
                    break;

                case "Cowboy":
                    cowboy.SetActive(true);

                    effectApplied = true;
                    break;

                case "Uh oh":
                    //
                    break;

                case "Molecule Mack":
                    p1.transform.localScale *= 0.25f;
                    p2.transform.localScale *= 0.25f;
                    effectApplied = true;
                    break;

                case "PASTA TIME":
                    //
                    break;

                case "?̸̢̨̱̼̼̻̠̱̦̈́͛̓̏̿́̋̑̀̑͊͛͜͝?̴̧̠͉͈̫̣̯͙͇͇̅̆͌̽̚?̸̧̨̻̭͈̥̻̪̯̣͠?̸̡͖̦̻̖̙̥̺̆̃̅͐̆̈̾̾̇͑ͅ?̴̛͚̰͔́͒?̶͓̩͔̺̱̤̟̥̗̉͝ͅ?̴̩͇̩͙̪͕͖̘̮̺̈͌͗̿̇̎̉͘͘͝?̶̧̩͔̯̲͈̦͚̙̘͖̟͎͗̄̔̿̊̓̍͗͒̆̎̑́̎͋?̶͕̙͓̞̗͚̞̣̀̎̔":
                    p1.transform.localScale = new Vector3(p1.transform.localScale.x, p1.transform.localScale.y*2.5f, p1.transform.localScale.z);
                    p2.transform.localScale = new Vector3(p2.transform.localScale.x, p2.transform.localScale.y * 2.5f, p2.transform.localScale.z);

                    effectApplied = true;
                    break;

                case "Yin and Yang":
                    // Cat in the middle, if anyone touches them they lose
                    break;

                case "V.O.R.E":
                    //
                    break;

                case "Engineer Eric":
                    //
                    break;

                case "Photogenic Kitty":
                    // This is the background
                    break;

                case "Meowing Felix":
                    //
                    break;

                case "LÖÖP BÖÖP":
                    // The floor is a LÖÖP
                    break;

                case "Cat":
                    // Nah
                    break;

                case "Black Mack":
                    // Screen fades to dark
                    break;

                case "Vacuum Sucker":
                    // The floor is a funnel
                    break;
            }
        }

    }
}
