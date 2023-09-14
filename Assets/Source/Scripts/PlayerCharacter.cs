using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private const float TorquePerSecond = 1000f;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal");
        _rigidbody.AddTorque(-input * Time.deltaTime * TorquePerSecond * _rigidbody.mass);
    }

    private void Update()
    {
        bool jumpInput = Input.GetButtonDown("Jump");
        if (jumpInput)
            _rigidbody.AddForce(new Vector2(0f, 300f * _rigidbody.mass));
    }
}
