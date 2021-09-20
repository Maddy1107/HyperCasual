using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.PickupObjects += PickupObjects;
    }

    private void PickupObjects(string name)
    {
        Debug.Log(name);
    }

    private void OnDisable()
    {
        GameEvents.PickupObjects -= PickupObjects;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameEvents.PickupObjects?.Invoke(other.gameObject.name);
        Destroy(other.gameObject);
    }
}
