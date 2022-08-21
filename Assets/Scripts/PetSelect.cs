using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PetSelect : MonoBehaviour
{
    public Pet[] _pet;

    public Image petImage;
    public string petName;
    public int attack;
    public int defense;
    public int speed;
    public int maxHealth;
    [TextArea]
    public string description;

    public string descriptionText;
    public Text _text;

    public int index;

    public GameObject _playerPet;


    // Start is called before the first frame update
    void Start()
    {
        index = 0;

        petImage.sprite = _pet[0].petSprite;
        petName = _pet[0].petName;
        attack = _pet[0].attack;
        defense = _pet[0].defense;
        speed = _pet[0].speed;
        maxHealth = _pet[0].maxHealth;
        description = _pet[0].description;

        descriptionText = petName + "\n" + "Attack: " + attack + "  Defense: "+defense + "  Speed: " +speed+ "\n"+ "Health: "+maxHealth + "\nBio: "+description;

        _text.text = descriptionText;
    }

    /// <summary>
    /// Confirm the pet selection
    /// </summary>
    public void PetSelected() 
    {
        _playerPet.GetComponent<PlayerPet>().petImage = petImage.sprite;
        _playerPet.GetComponent<PlayerPet>().petName = petName;
        _playerPet.GetComponent<PlayerPet>().attack = attack;
        _playerPet.GetComponent<PlayerPet>().defense = defense;
        _playerPet.GetComponent<PlayerPet>().speed = speed;
        _playerPet.GetComponent<PlayerPet>().maxHealth = maxHealth;
        _playerPet.GetComponent<PlayerPet>().description = description;

        DontDestroyOnLoad(_playerPet.gameObject);


        SceneManager.LoadScene("Game");
    }

    /// <summary>
    /// Next Pet Button
    /// </summary>
    public void NextPet() 
    {
        
        if (index >= _pet.Length - 1)
        {
            index = 0;

           
        }
        else
        {
            index++;
        }

        petImage.sprite = _pet[index].petSprite;
        petName = _pet[index].petName;
        attack = _pet[index].attack;
        defense = _pet[index].defense;
        speed = _pet[index].speed;
        maxHealth = _pet[index].maxHealth;
        description = _pet[index].description;
        descriptionText = petName + "\n" + "Attack: " + attack + "  Defense: " + defense + "  Speed: " + speed + "\n" + "Health: " + maxHealth + "\nBio: " + description;
        _text.text = descriptionText;

    }

    /// <summary>
    /// Previous Pet Button
    /// </summary>
    public void PreviousPet()
    {
       
        if (index ==0)
        {
            index = _pet.Length-1;


        }
        else
        {
            index--;
        }

        petImage.sprite = _pet[index].petSprite;
        petName = _pet[index].petName;
        attack = _pet[index].attack;
        defense = _pet[index].defense;
        speed = _pet[index].speed;
        maxHealth = _pet[index].maxHealth;
        description = _pet[index].description;
        descriptionText = petName + "\n" + "Attack: " + attack + "  Defense: " + defense + "  Speed: " + speed + "\n" + "Health: " + maxHealth + "\nBio: " + description;
        _text.text = descriptionText;

    }




}
