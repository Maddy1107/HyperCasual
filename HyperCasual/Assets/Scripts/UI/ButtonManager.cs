using UnityEngine;
using System;

public class ButtonManager : MonoBehaviour
{
    public GameObject LevelScreen;
    public GameObject MainMenu;

    [NonSerialized] public int levelid;

    public void ReturnHome()
    {
        MainMenu.gameObject.SetActive(true);
    }

    public void LevelScreenOpen()
    {
        LevelScreen.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        throw new NotImplementedException();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        MainMenu.gameObject.SetActive(false);
        LevelScreen.gameObject.SetActive(true);
    }
}
