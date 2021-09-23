using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int levelid;

    private void Awake()
    {
        instance = this;
    }

    public void setLevel(int level)
    {
        levelid = level;
    }
}
