using UnityEngine;

public class WinScript : MonoBehaviour
{
    public Animator playerAnimator;

    private void OnEnable()
    {
        GameEvents.onWin += onWin;
    }

    private void onWin()
    {
        playerAnimator.SetBool("Win", true);
        GameEvents.ShowWinScreen?.Invoke();
    }

    private void OnDisable()
    {
        GameEvents.onWin -= onWin;
    }
}
