using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFood : MonoBehaviour
{
    public GameObject foodPanel;

    public Food[] _food;
    public int index;

    public string foodName;
    public int recover;
    public int price;
    public Image foodSprite;
    [TextArea]
    public string description;

    public Text foodDescriptionTxt;

    private void Start()
    {
        index = 0;

        foodName = _food[0].foodName;
        recover = _food[0].recover;
        price = _food[0].price;
        foodSprite.sprite = _food[0].foodSprite;
        description = _food[0].description;
     



    }

    /// <summary>
    /// closes the food panel
    /// </summary>
    public void ClosePanel() 
    {
        foodPanel.SetActive(false);
    }

}
