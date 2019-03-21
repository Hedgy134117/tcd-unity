using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour {

    public void mouseEnter()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void mouseExit()
    {
        this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void StartButton()
    {
        if (GameObject.Find("CatManager") != null)
        {
            Destroy(GameObject.Find("CatManager"));
        }
        if (GameObject.Find("SettingsManager") != null)
        {
            Destroy(GameObject.Find("SettingsManager"));
        }
        SceneManager.LoadScene(SceneUtility.GetBuildIndexByScenePath("_Scenes/CharacterSelectScene"));


    }

    public void ControlsButton()
    {
        SceneManager.LoadScene(SceneUtility.GetBuildIndexByScenePath("_Scenes/ControlsScene"));
    }

    public void HTPButton()
    {
        SceneManager.LoadScene(SceneUtility.GetBuildIndexByScenePath("_Scenes/IntroScene"));
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene(SceneUtility.GetBuildIndexByScenePath("_Scenes/CreditsScene"));
    }

}
