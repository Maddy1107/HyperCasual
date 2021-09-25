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
    public TextMeshProUGUI DiamondCounterText;
    public TextMeshProUGUI LettersCollectedText;
    public TextMeshProUGUI LettersCollectedTitle;
    public TextMeshProUGUI Totaldiamondscollected;
    public TextMeshProUGUI DiamondsafterBonus;

    public Image TimeImage;
    
    bool isLevelpass;

    private string Allletters = "";

    private float Totaltime = 10f;
    private float Timer;

    public int DiamondCounter;
    public static int totalDiamondCounter;

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
        GameEvents.SendOtherPickupDetailst += SendOtherPickupDetailst;
        GameEvents.ShowWinScreen += ShowWinScreen;
        GameEvents.ShowDeathnScreen += ShowDeathnScreen;
    }

    private void SendOtherPickupDetailst(string obj)
    {
        if(obj == "Diamonds")
        {
            DiamondCounter += 1;
            DiamondCounterText.SetText("* " + DiamondCounter);
            totalDiamondCounter += 1;
        }
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
        foreach (var item in CollectedAlphabets)
        {
            Allletters += item;
            Allletters += ", ";
        }

        LettersCollectedTitle.gameObject.SetActive(true);
        LettersCollectedText.SetText(Allletters);

        TimeImage.gameObject.SetActive(true);

        keyboard.gameObject.SetActive(true);

        StartCoroutine(Countdown());

        QuesInstruction.gameObject.SetActive(true);

    }

    private void ShowWinScreen(int bonus)
    {
        DiamondsafterBonus.SetText(bonus.ToString());
        WinScreen.gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        GameEvents.ShowLevelPassScreen -= ShowLevelPassScreen;
        GameEvents.SendAlphabetList -= SendAlphabetList;
        GameEvents.SendOtherPickupDetailst += SendOtherPickupDetailst;
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

        GameEvents.OnKeyboard?.Invoke(CollectedAlphabets);

        CountdownText.gameObject.SetActive(false);
        isLevelpass = true;
    }
}
