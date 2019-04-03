using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{

    // enlarge on hover
    public void mouseEnter()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void mouseExit()
    {
        this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void Continue()
    {
        // load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        // check if the scene is the start scene & if it is then remove all managers
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (GameObject.Find("SettingsManager") != null)
            {
                Destroy(GameObject.Find("SettingsManager"));
            }
            if (GameObject.Find("CatManager") != null)
            {
                Destroy(GameObject.Find("CatManager"));
            }
        }
    }
}
