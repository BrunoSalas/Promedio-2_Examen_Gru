using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManaguerNivel2 : MonoBehaviour,ISubject
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
    public List<IObserver> observers = new List<IObserver>();
    public TextMeshProUGUI tex; private static ManaguerNivel2 instance;
    void Start()
    {

    }
    private void Awake()
    {
        instance = this;
    }
    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        observers.Remove(observer);
    }
    public static ManaguerNivel2 GetInstance()
    {
        return instance;
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
    }
}
