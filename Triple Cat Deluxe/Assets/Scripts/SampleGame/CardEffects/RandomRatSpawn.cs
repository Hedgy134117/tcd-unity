﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRatSpawn : MonoBehaviour {

    public void randomSpawn()
    {
        // spawn at a random position
        transform.position = new Vector3(Random.Range(-5f, 5f), 3f, 0f);
    }

}
