using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCharacterSelect : MonoBehaviour {

    public CatManager catManager;
    public List<GameObject> catNames;
    public CurrentPlayer currentPlayer;

    public void randomCharacterSelect()
    {
        catManager.p1 = catNames[Random.Range(0, catNames.Count)].name;
        catManager.p2 = catNames[Random.Range(0, catNames.Count)].name;
        while (catManager.p2 == catManager.p1)
        {
            catManager.p2 = catNames[Random.Range(0, catNames.Count)].name;
        }

        currentPlayer.playerSelecting = 0;
    }
}
