using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    private string alphabetCollected;

    public TextMeshProUGUI alphabetList;

    List<string> CollectedAlphabets = new List<string>();

    private TouchScreenKeyboard keyboard;

    private void OnEnable()
    {
        GameEvents.ShowWinScreen += ShowWinScreen;
        GameEvents.SendAlphabetList += SendAlphabetList;
    }

    private void SendAlphabetList(string letter)
    {
        CollectedAlphabets.Add(letter);
    }

    private void ShowWinScreen()
    {
        foreach(var n in CollectedAlphabets)
        {
            alphabetCollected += n;
            alphabetCollected += ", ";
        }

        alphabetList.SetText(alphabetCollected);

    }

    private void OnDisable()
    {
        GameEvents.ShowWinScreen -= ShowWinScreen;
        GameEvents.SendAlphabetList -= SendAlphabetList;
    }

    private void OnGUI()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }
}
