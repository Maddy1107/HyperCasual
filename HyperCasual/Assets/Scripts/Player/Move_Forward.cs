using UnityEngine;

public class Move_Forward : Movement
{
    private void FixedUpdate()
    {
        Move(Vector3.forward);
    }
}
