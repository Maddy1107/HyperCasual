using UnityEngine;

public class MovingCubeScript : MonoBehaviour
{
    private float LeftXlimit = -1.5f;

    private float RightXlimit = 1.5f;

    private bool goRight = false;

    private float xvalue = 0;

    private void Update()
    {
        if (xvalue < LeftXlimit)
            goRight = true;
        else if(xvalue > RightXlimit)
            goRight = false;

        xvalue += (goRight ? 2f : -2f) * Time.deltaTime;
        
        transform.position = new Vector3(xvalue, transform.position.y, transform.position.z);
    }
}
