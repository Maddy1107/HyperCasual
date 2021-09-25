using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardScript : MonoBehaviour
{
    Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(KeyType);
    }

    private void KeyType()
    {
        GameEvents.OnKeyboardType?.Invoke(gameObject.name);
    }

    private void OnEnable()
    {
        GameEvents.OnKeyboard += OnKeyboard;
    }

    private void OnKeyboard(List<string> collectedLetters)
    {
        foreach(var l in collectedLetters)
        {
            if (gameObject.name == l)
            {
                GetComponent<Button>().interactable = true;
                break;
            }
        }

        if(gameObject.name == "Enter")
        {
            GetComponent<Button>().interactable = true;
        }
    }

    private void OnDisable()
    {
        GameEvents.OnKeyboard -= OnKeyboard;
    }
}
