using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBoing : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento
    public Vector3 direction = Vector3.right; // Dirección de movimiento inicial

    private Renderer planeRenderer;
    private Bounds planeBounds;
    private bool isMovingRight = true;

    private void Start()
    {
        planeRenderer = GetComponent<Renderer>();
        planeBounds = planeRenderer.bounds;
    }

    private void Update()
    {
        // Obtener el tamaño del plano en la pantalla
        float planeWidth = planeBounds.size.x;
        float planeHeight = planeBounds.size.z;

        // Calcular los límites de movimiento
        float xMin = -Camera.main.aspect * Camera.main.orthographicSize + planeWidth / 2f;
        float xMax = Camera.main.aspect * Camera.main.orthographicSize - planeWidth / 2f;
        float zMin = -Camera.main.orthographicSize + planeHeight / 2f;
        float zMax = Camera.main.orthographicSize - planeHeight / 2f;

        // Actualizar la posición del plano
        transform.Translate(direction * speed * Time.deltaTime);

        // Rebotar el plano cuando alcanza los límites
        if (transform.position.x <= xMin || transform.position.x >= xMax)
        {
            isMovingRight = !isMovingRight;
            direction.x = isMovingRight ? 1f : -1f;
        }

        if (transform.position.z <= zMin || transform.position.z >= zMax)
        {
            direction.y = -direction.y;
        }
    }
}
