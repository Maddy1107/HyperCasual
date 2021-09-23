using UnityEngine;
using TMPro;

public class KeyboardType : MonoBehaviour
{
    private string AnswerText = "";

    public TextMeshProUGUI AnswerField;

    private void OnEnable()
    {
        GameEvents.OnKeyboardType += OnKeyboardType;
    }

    private void OnKeyboardType(string AnswerLetter)
    {
        if (AnswerLetter != "BackSpace" && AnswerLetter != "Enter")
        {
            AnswerText += AnswerLetter;
        }
        else if (AnswerLetter == "BackSpace" && AnswerText.Length > 0 && AnswerText != null)
        {
            AnswerText = AnswerText.Remove(AnswerText.Length - 1);
        }
        else if (AnswerLetter == "Enter")
        {
            GameEvents.Bonuscheck?.Invoke(1,AnswerText);
        }

        AnswerField.SetText(AnswerText);
    }

    private void OnDisable()
    {
        GameEvents.OnKeyboardType += OnKeyboardType;
    }
}
