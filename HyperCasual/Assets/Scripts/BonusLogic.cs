using System.Collections;
using UnityEngine;

public class BonusLogic : MonoBehaviour
{
    private Hashtable answers = new Hashtable();

    private int LettermatchIndex = 0;

    public ButtonManager buttonmanager;

    private void Start()
    {
        answers.Add(1, "LIE");
    }

    private void OnEnable()
    {
        GameEvents.Bonuscheck += Bonuscheck;
    }

    private void Bonuscheck(int level,string answer)
    {
        string ActualAnswer = (string)answers[level];
        if(answer == ActualAnswer)
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

    }

    private void OnDisable()
    {
        GameEvents.Bonuscheck += Bonuscheck;
    }
}
