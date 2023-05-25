using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManaguerNivel2 : MonoBehaviour
{
    public GameObject spawnLeft;
    public GameObject spawnRight;
    public Player2 player;
    [HideInInspector]
    public float saveDistance;
    [HideInInspector]
    public bool left;
    [HideInInspector]
    public bool right;
    public float distanceSpawn;
    public TextMeshProUGUI tex;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.distanceTraveled > saveDistance + distanceSpawn)
        {
           int i = Random.Range(0, 3);
            switch(i)
            {
                case 1:
                    saveDistance = player.distanceTraveled;
                    spawnLeft.SetActive(true);
                    spawnLeft.SetActive(false);
                    break;
                case 2:
                    saveDistance = player.distanceTraveled;
                    spawnRight.SetActive(true);
                    spawnRight.SetActive(false);
                    break;
                case 3:
                    saveDistance = player.distanceTraveled;
                    spawnRight.SetActive(true);
                    spawnRight.SetActive(true);
                    break;
            }

        }
        tex.text = $"Distancia Recorrida: {((int)player.distanceTraveled).ToString()}";
    }
}
