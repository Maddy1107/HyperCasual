using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static Action<GameObject, Transform> SpawnBullet;

    public static Action<string> PickupObjects;
}
