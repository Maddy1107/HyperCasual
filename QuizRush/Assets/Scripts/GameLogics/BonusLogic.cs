using System.Collections;
using UnityEngine;

public class BonusLogic : MonoBehaviour
{
    private Hashtable answers = new Hashtable();

    private int LettermatchIndex = 0;

    private void Start()
    {
        answers.Add(1, "LIE");
        answers.Add(2, "MARS");
        answers.Add(3, "COVID");
        answers.Add(4, "WOODY");
        answers.Add(5, "GREECE");
    }

    private void OnEnable()
    {
        GameEvents.Bonuscheck += Bonuscheck;
    }

    private void Bonuscheck(int level,string answer)
    {
        string ActualAnswer = (string)answers[level];

        if (answer == ActualAnswer)
        {
            GiveReward(ActualAnswer.Length);
        }
        else
        {
            for (int i = 0; i < answer.Length; i++)
            {
                if(answer[i] == ActualAnswer[i])
                {
                    LettermatchIndex += 1;
                }
            }

            GiveReward(LettermatchIndex);
        }
    }

    private void GiveReward(int LetterMatchCount)
    {
        UIManager.totalDiamondCounter += LetterMatchCount * 10;
        GameEvents.ShowWinScreen?.Invoke(LetterMatchCount * 10);
    }

    private void OnDisable()
    {
        GameEvents.Bonuscheck += Bonuscheck;
    }
}
