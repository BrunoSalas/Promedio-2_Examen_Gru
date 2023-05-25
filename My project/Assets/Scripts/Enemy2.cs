using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

 class Enemy2 : MonoBehaviour,IObserver
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
    private void Awake()
    {
        ManaguerNivel2.GetInstance().Attach(this);

    }
    private void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Execute(ManaguerNivel2.GetInstance());
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    public  void Fire(GameObject i)
    {
        Instantiate(i, bulletSpawnPoint.position, Quaternion.identity);
    }

    public void Execute(ISubject subject)
    {
        Action<GameObject> action = Fire;
        action(bulletPrefab);
    }
}
