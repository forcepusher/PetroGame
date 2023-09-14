using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private const float TorquePerSecond = 500f;
    private const float MaximumAngularVelocity = 10f;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal");
        _rigidbody.AddTorque(-input * Time.deltaTime * TorquePerSecond);

    }
}
