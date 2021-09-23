using UnityEngine;

public class MoveForward : Movement
{
    private void FixedUpdate()
    {
        Move(Vector3.forward);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "End")
        {
            speed = 0;
            GameEvents.onLevelPass?.Invoke();
        }
    }
}
