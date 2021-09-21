using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.OnDeath += OnDeath;
    }

    private void OnDeath()
    {
        Debug.Log("Player Dead");
    }

    private void OnDisable()
    {
        GameEvents.OnDeath -= OnDeath;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            GameEvents.OnDeath?.Invoke();
        }
    }
}
