using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    [SerializeField]
    private bool canMoveLeft = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput < 0 && canMoveLeft)
        {
            rb.velocity = new Vector3(horizontalInput * speed, rb.velocity.y, rb.velocity.z);
        }
        else if (horizontalInput > 0)
        {
            rb.velocity = new Vector3(horizontalInput * speed, rb.velocity.y, rb.velocity.z);
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }

        // Movimiento vertical (eje Z)
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput > 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, verticalInput * speed);
        }
        else if (verticalInput < 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
        }
    }

    // Método para desactivar el movimiento a la izquierda
    public void DisableLeftMovement()
    {
        canMoveLeft = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("BalaEnemigo"))
        {
            Destroy(gameObject);
        }
    }
}
