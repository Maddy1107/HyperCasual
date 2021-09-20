using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform firepoint;

    private float nextbulletSpawnTime;

    private float firerate = 0.1f;

    void Update()
    {
        if (nextbulletSpawnTime < Time.time)
        {
            GameEvents.SpawnBullet?.Invoke(bulletPrefab, firepoint);
            nextbulletSpawnTime = Time.time + firerate;
        }
    }
}
