using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNivel1 : MonoBehaviour
{
    public float timer;
    public GameObject spawnPrefabEnemy;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2)    
        {

            Instantiate(spawnPrefabEnemy, transform.parent.position + transform.localPosition, transform.parent.rotation);
            timer= 0;

        }
    }


}
