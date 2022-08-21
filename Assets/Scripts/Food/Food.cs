using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Food", menuName
= "Food Creation")]
public class Food : ScriptableObject
{
    public string foodName;
    public int recover;
    public int price;
    public Sprite foodSprite;
    [TextArea]
    public string description;

}

