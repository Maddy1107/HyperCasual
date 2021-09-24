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

        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, LeftXlimit, RightXlimit);

        transform.position = pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "End")
        {
            speed = 0;
        }
    }
}
