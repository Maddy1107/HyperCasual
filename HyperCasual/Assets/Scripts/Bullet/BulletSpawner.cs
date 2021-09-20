using UnityEngine;

[RequireComponent(typeof(PlayerShoot))]
public class BulletSpawner : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.SpawnBullet += SpawnBullet;
    }

    private void OnDisable()
    {
        GameEvents.SpawnBullet -= SpawnBullet;
    }

    private void SpawnBullet(GameObject bulletPrefab, Transform firepoint)
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, Quaternion.identity);
        Destroy(bullet, 2f);
    }

}
