using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{    
    public void LevelLoader(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
}
