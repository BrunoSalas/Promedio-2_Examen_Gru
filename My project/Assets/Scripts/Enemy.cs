using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementSpeed = 5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 movement = Vector3.back * movementSpeed;
        rb.velocity = movement;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("BulletPlayer"))
        {

            Destroy(gameObject);

        }
    }
}
