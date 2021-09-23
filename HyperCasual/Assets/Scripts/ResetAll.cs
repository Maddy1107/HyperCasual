using System.Collections.Generic;
using UnityEngine;

public class ResetAll : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.Reset += Reset;
    }

    private void Reset(List<string> obj)
    {
        obj.Clear();
    }

    private void OnDisable()
    {
        GameEvents.Reset -= Reset;
    }
}
