using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(2);

    }

    public void goToMain()
    {
       
        SceneManager.LoadScene(0);
        time.timePerQuestion = ToggleButtons.timer;


    }

    public void begin()
    {
        SceneManager.LoadScene(0);
       

    }

    public void startNewGame()
    {
        SceneManager.LoadScene(3);

    }

    public void nextScreen()
    {
        SceneManager.LoadScene(2);
    }

    public void endGame()
    {
        SceneManager.LoadScene(4);

    }
}