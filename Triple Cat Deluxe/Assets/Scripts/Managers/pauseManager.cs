using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseManager : MonoBehaviour
{
    // the actual pause menu UI
    public GameObject pauseMenu;
    // to stop the floor from shrinking in the pause menu
    public ShrinkingFloor floor;

    // button enlarge on hover
    public void mouseEnter()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void mouseExit()
    {
        this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void Pause ()
    {
        // activate the pause menu UI
        pauseMenu.SetActive(true);
        // stop the floor from shrinking
        floor.sizeToShrinkBy = 0f;
        // stop any physics from happening (most action)
        Time.timeScale = 0f;
    }
}
