﻿using System;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static Action<GameObject> PickupObjects;

    public static Action OnDeath;

    public static Action onLevelPass;

    public static Action ShowLevelPassScreen;

    public static Action<int> ShowWinScreen;

    public static Action ShowDeathnScreen;

    public static Action<string> SendAlphabetList;

    public static Action<string> SendOtherPickupDetailst;

    public static Action<int> SendDiamondCounter;

    public static Action<List<string>> OnKeyboard;

    public static Action<string> OnKeyboardType;

    public static Action<int,string> Bonuscheck;
}
