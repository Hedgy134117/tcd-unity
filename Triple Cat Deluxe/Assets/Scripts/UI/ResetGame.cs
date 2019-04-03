using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {

    public void resetGame()
    {
	// load the first scene and destroy any settingsmanagers
        SceneManager.LoadScene(0);
        Destroy(GameObject.Find("SettingsManager"));
    }

}
