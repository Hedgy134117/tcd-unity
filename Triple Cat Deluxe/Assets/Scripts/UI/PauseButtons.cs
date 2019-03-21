using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtons : MonoBehaviour {

    public GameObject pauseMenu;
    public ShrinkingFloor floor;

	public void Continue()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        floor.sizeToShrinkBy = .001f;
    }

    public void Quit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
