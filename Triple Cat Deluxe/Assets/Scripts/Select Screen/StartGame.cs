using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    // variables
    public CurrentPlayer cp;

    // enlarge on hover
    public void mouseEnter()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void mouseExit()
    {
        this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void Update()
    {
        // while the player selecting is 1 or 2 then the user can't continue
        if(cp.playerSelecting > 0)
        {
            this.gameObject.GetComponent<Button>().interactable = false;
        }
        // otherwise the player can start the game
        else
        {
            this.gameObject.GetComponent<Button>().interactable = true;
        }
    }

    public void startGame()
    {
        // load the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
