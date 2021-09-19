using UnityEngine;

public class BulletScript : Movement
{
    private void FixedUpdate()
    {
        Move(Vector3.forward);
    }
}
