using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    //pet
    public GameObject _pet;
    public Image _petImage;
    public string petName;
    //attributes
    public int attack;
    public int defense;
    public int speed;
    public int maxHealth;
    [TextArea]
    public string description;




    //status
    public int hungry;
    public int thirsty;
    public int stamina;
    


    private void Start()
    {
        _pet = GameObject.FindGameObjectWithTag("Player");

        if (petName == null)
        {
            _petImage.sprite = _pet.GetComponent<PlayerPet>().petImage;
            petName = _pet.GetComponent<PlayerPet>().petName;
            attack = _pet.GetComponent<PlayerPet>().attack;
            defense = _pet.GetComponent<PlayerPet>().defense;
            speed = _pet.GetComponent<PlayerPet>().speed;
            maxHealth = _pet.GetComponent<PlayerPet>().maxHealth;
            description = _pet.GetComponent<PlayerPet>().description;
        }



    }

    private void Update()
    {
       
    }

    

    /// <summary>
    /// Remove hungry
    /// </summary>
    /// <param name="food"></param>
    public void Eat(string food) 
    {

    }

}
