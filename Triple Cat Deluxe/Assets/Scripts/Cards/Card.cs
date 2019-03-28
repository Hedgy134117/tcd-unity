using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is not really used much more. used when the cards were not all images.

// script to create a new card
[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject {

    public new string name;
    public string description;
    public string use;
    public Sprite image;

    public int pointsToAdd;
}
