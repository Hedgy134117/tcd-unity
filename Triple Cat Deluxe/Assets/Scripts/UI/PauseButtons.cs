using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtons : MonoBehaviour {

    public GameObject pauseMenu;
    public ShrinkingFloor floor;

    public void Continue()
    {
	    // continue all physics calculations and movement
        Time.timeScale = 1f;
	    // unload the pause menu UI
        pauseMenu.SetActive(false);
	    // make the floor start shrinking again
        floor.sizeToShrinkBy = .001f;
    }

    public void Quit()
    {
	    // continue all physics calculations and movement
        Time.timeScale = 1f;
	    // go to start
        SceneManager.LoadScene(0);
    }
}
