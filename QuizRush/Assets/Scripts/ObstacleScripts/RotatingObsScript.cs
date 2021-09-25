using UnityEngine;

public class RotatingObsScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private string axis;

    void Update()
    {
        if(axis == "x")
            transform.Rotate(new Vector3(speed, 0, 0), Space.Self);
        else if(axis == "y")
            transform.Rotate(new Vector3(0, speed, 0), Space.Self);
        else
            transform.Rotate(new Vector3(0, 0, speed), Space.Self);

    }
}
