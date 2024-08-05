using System;
using UnityEngine;

public class TPSController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 input;
    [SerializeField]private FixedJoystick fixedJoystick;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        input.x = fixedJoystick.Horizontal;
        input.z = fixedJoystick.Vertical;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.TransformDirection(input * speed * Time.fixedDeltaTime));
    }
}
