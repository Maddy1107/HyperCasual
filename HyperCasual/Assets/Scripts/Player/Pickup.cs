using UnityEngine;

public class Pickup : MonoBehaviour
{
    public ParticleSystem pickupParticle;

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
        else if (pickup.tag == "Diamond")
        {
            GameEvents.SendOtherPickupDetailst?.Invoke("Diamonds");
        }
    }

    private void OnDisable()
    {
        GameEvents.PickupObjects -= PickupObjects;
    }

    private void OnTriggerEnter(Collider other)
    {
        ParticleSystem Particlepick = Instantiate(pickupParticle, transform.position, Quaternion.identity);
        GameEvents.PickupObjects?.Invoke(other.gameObject);
        Destroy(other.gameObject);
        Destroy(Particlepick, 1);
    }
}
