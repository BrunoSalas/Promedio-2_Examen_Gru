using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBoing : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    private Vector3 direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = new Vector3(1f, 1f, 0f).normalized;
    }

    private void Update()
    {
        rb.velocity = direction * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        direction = Vector3.Reflect(direction, collision.contacts[0].normal);
    }
}
