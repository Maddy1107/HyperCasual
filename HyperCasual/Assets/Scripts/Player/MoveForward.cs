using UnityEngine;

public class MoveForward : Movement
{
    private void FixedUpdate()
    {
        Move(Vector3.forward);
    }
}
