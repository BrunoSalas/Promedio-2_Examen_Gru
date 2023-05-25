using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform bulletSpawnPoint; 
    public float bulletSpeed = 10f;  
    public float fireRate = 1f;  

    private float nextFireTime;

    private void Start()
    {
        nextFireTime = Time.time; 
    }

    private void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Fire();  
            nextFireTime = Time.time + 1f / fireRate;  
        }
    }

    private void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.velocity = transform.right * bulletSpeed;
    }
}
