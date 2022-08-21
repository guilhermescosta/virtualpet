using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    /// <summary>
    /// Start a New Game
    /// </summary>
    public void NewGame() 
    {
        SceneManager.LoadScene("PetSelect");
    }

    /// <summary>
    /// Resume Previous Game
    /// </summary>
    public void ResumeGame() 
    {

    }

}
