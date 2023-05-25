using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victoria : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.getInstance().Victoria();
            GameManager.getInstance().victory.SetActive(true);
        }
    }
}
