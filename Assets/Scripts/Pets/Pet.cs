using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Pet", menuName
= "Pet Creation")]
public class Pet : ScriptableObject
{
    public string petName;
    public int attack;
    public int defense;
    public int speed;
    public int maxHealth;
    public Sprite petSprite;
    [TextArea]
    public string description;

}
