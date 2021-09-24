using UnityEngine;
using TMPro;

public class DiamondCounterShowScript : MonoBehaviour
{
    private void Update()
    {
        GetComponent<TextMeshProUGUI>().SetText("* " + UIManager.totalDiamondCounter.ToString());
    }
}
