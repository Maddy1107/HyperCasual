using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Movement : MonoBehaviour
{
    public float speed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        _rigidbody.MovePosition(_rigidbody.position + (direction * speed * Time.deltaTime));
    }
}
