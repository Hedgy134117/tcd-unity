using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

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
