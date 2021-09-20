using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform firepoint;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameEvents.SpawnBullet?.Invoke(bulletPrefab, firepoint);
        }
    }
}
