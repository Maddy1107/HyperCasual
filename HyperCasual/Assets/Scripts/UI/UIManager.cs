using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI alphabetList;
    public TextMeshProUGUI CountdownText;
    public TextMeshProUGUI QuesInstruction;

    public Image TimeImage;

    bool isLevelpass;

    private float Totaltime = 10f;
    private float Timer;

    private List<string> CollectedAlphabets = new List<string>();

    public GameObject keyboard;
    public GameObject WinScreen;
    public GameObject DeathScreen;

    private void Start()
    {
        Timer = Totaltime;
        isLevelpass = false;
    }
    private void OnEnable()
    {
        GameEvents.ShowLevelPassScreen += ShowLevelPassScreen;
        GameEvents.SendAlphabetList += SendAlphabetList;
        GameEvents.ShowWinScreen += ShowWinScreen;
        GameEvents.ShowDeathnScreen += ShowDeathnScreen;
    }

    private void ShowDeathnScreen()
    {
        DeathScreen.gameObject.SetActive(true);
    }

    private void SendAlphabetList(string letter)
    {
        CollectedAlphabets.Add(letter);
    }

    private void ShowLevelPassScreen()
    {
        keyboard.gameObject.SetActive(true);

        StartCoroutine(Countdown());

        QuesInstruction.gameObject.SetActive(true);

        GameEvents.OnKeyboard?.Invoke(CollectedAlphabets);
    }

    private void ShowWinScreen()
    {
        WinScreen.gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        GameEvents.ShowLevelPassScreen -= ShowLevelPassScreen;
        GameEvents.SendAlphabetList -= SendAlphabetList;
        GameEvents.ShowWinScreen -= ShowWinScreen;
        GameEvents.ShowDeathnScreen -= ShowDeathnScreen;
    }

    private void Update()
    {
        if (isLevelpass)
        {
            if(Timer <= 0)
            {
                Timer = Totaltime;
                isLevelpass = false;
                GameEvents.OnKeyboardType?.Invoke("Enter");
            }
            else
            {
                Timer -= Time.deltaTime;
            }
        }

        TimeImage.fillAmount = Timer/Totaltime;
    }

    private IEnumerator Countdown()
    {
        float duration = 3f;
        while (duration >= 0)
        {
            yield return new WaitForSeconds(1);
            CountdownText.SetText(((int)duration).ToString());
            duration--;
        }
        CountdownText.SetText("Go!!!");
        yield return new WaitForSeconds(1);

        TimeImage.gameObject.SetActive(true);
        CountdownText.gameObject.SetActive(false);
        isLevelpass = true;
    }
}
