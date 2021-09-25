using UnityEngine;

public class JumpPadScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Animator playerAnimator = other.gameObject.GetComponent<Animator>();
        playerAnimator.SetTrigger("Jump");

        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        AudioManager.instance.Play("Bounce");
    }
}
