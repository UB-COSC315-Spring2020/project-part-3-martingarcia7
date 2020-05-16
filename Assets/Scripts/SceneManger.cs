using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    //this script handles the different variations of methods that are placed into different buttons. Each method assigns a different scene to be loaded once that specific button with the method is pressed.
    public void PlayLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
        ScoringScript.fruitCount = 0; //resets the fruit count to zero
    }

    
}
