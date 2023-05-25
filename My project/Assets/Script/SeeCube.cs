using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeCube : MonoBehaviour
{
    public float timer;
    public GameObject interfaz;
    public GameObject cubo;
    public GameObject c2;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 8) 
        {
            interfaz.SetActive(false);
            cubo.SetActive(true);
            c2.SetActive(true);
        }

    }
    public void SeeInterfaz()
    {
        interfaz.SetActive(true);
        cubo.SetActive(false);
        c2.SetActive(false);
        timer = 0;
    }
}
