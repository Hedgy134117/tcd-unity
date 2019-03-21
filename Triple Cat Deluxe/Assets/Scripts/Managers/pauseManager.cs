using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public ShrinkingFloor floor;

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
        pauseMenu.SetActive(true);
        floor.sizeToShrinkBy = 0f;
        Time.timeScale = 0f;
    }
}
