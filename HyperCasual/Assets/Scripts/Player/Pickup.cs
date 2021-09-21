using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.PickupObjects += PickupObjects;
    }

    private void PickupObjects(GameObject pickup)
    {
        if(pickup.tag == "Alphabets")
        {
            GameEvents.SendAlphabetList?.Invoke(pickup.gameObject.name);
        }
    }

    private void OnDisable()
    {
        GameEvents.PickupObjects -= PickupObjects;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameEvents.PickupObjects?.Invoke(other.gameObject);
        Destroy(other.gameObject);
    }
}
