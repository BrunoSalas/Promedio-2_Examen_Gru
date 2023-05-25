using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefabEnemy;
    // Start is called before the first frame update
    private void Awake()
    {
    }
    private void OnEnable()
    {
            Instantiate(prefabEnemy, transform.parent.position + transform.localPosition, transform.parent.rotation);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
