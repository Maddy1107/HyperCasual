using UnityEngine;

public class MoveSide : Movement
{
    private float LeftXlimit = -2f;

    private float RightXlimit = +2f;

    private void Update()
    {
        if (Input.touchCount == 1)
        {
            var touch = Input.touches[0];
            if (touch.position.x < Screen.width / 2)
            {
                Move(Vector3.left);
            }
            else if (touch.position.x > Screen.width / 2)
            {
                Move(Vector3.right);
            }
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, LeftXlimit, RightXlimit),
            transform.position.y, transform.position.z);
    }
}
