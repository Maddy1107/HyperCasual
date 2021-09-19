using UnityEngine;

public abstract class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        _rigidbody.MovePosition(_rigidbody.position + (direction * speed * Time.deltaTime));
    }
}
