using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : Bullet
{

    protected override void Update()
    {
        rb.velocity = transform.right *speed;
    }
}
