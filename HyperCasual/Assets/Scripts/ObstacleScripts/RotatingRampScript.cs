using UnityEngine;

public class RotatingRampScript : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        transform.Rotate(new Vector3(speed, 0, 0), Space.Self);
    }
}
