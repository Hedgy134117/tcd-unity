using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetCharacters : MonoBehaviour {

    public void mouseEnter()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void mouseExit()
    {
        this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void ResetCharacters()
    {
        Destroy(GameObject.Find("CatManager"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
