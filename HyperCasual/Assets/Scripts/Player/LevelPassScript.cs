using UnityEngine;

public class LevelPassScript : MonoBehaviour
{
    public Animator playerAnimator;

    private void OnEnable()
    {
        GameEvents.onLevelPass += onLevelPass;
    }

    private void onLevelPass()
    {
        playerAnimator.SetBool("Win", true);
        GameEvents.ShowLevelPassScreen?.Invoke();
    }

    private void OnDisable()
    {
        GameEvents.onLevelPass -= onLevelPass;
    }
}
