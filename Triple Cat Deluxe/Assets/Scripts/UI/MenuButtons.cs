using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour {

    // enlarge on hover
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
        // destory all managers and load the character select scene
        if (GameObject.Find("CatManager") != null)
        {
            Destroy(GameObject.Find("CatManager"));
        }
        if (GameObject.Find("SettingsManager") != null)
        {
            Destroy(GameObject.Find("SettingsManager"));
        }
        if (GameObject.Find("StageManager") != null)
        {
            Destroy(GameObject.Find("StageManager"));
        }
        SceneManager.LoadScene(SceneUtility.GetBuildIndexByScenePath("_Scenes/CharacterSelectScene"));


    }

    public void ControlsButton()
    {
        // load the controls scene
        SceneManager.LoadScene(SceneUtility.GetBuildIndexByScenePath("_Scenes/ControlsScene"));
    }

    public void HTPButton()
    {
        // load the how to play scene
        SceneManager.LoadScene(SceneUtility.GetBuildIndexByScenePath("_Scenes/IntroScene"));
    }

    public void CreditsButton()
    {
        // load the credits scene
        SceneManager.LoadScene(SceneUtility.GetBuildIndexByScenePath("_Scenes/CreditsScene"));
    }

}
