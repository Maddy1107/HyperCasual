using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static Action<GameObject> PickupObjects;

    public static Action OnDeath;

    public static Action onWin;

    public static Action ShowWinScreen;

    public static Action<string> SendAlphabetList;

}
