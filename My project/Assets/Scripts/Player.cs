using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5f;

    private Rigidbody rb;

    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 10f;
    public float fireRate = 1f;

    private float nextFireTime;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0f, 0f) * movementSpeed;

        rb.velocity = movement;

    }

    private void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Action<GameObject> action = Fire;
            action(bulletPrefab);
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    public void Fire(GameObject i)
    {
        Instantiate(i, bulletSpawnPoint.position, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {

            Destroy(gameObject);
        }
    }
}
