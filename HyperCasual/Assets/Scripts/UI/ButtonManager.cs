using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{ 
    public void ReturnHome()
    {
        SceneManager.LoadScene(0);
    }

    public void LevelScreenOpen()
    {
        SceneManager.LoadScene(1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(GameManager.levelid + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
