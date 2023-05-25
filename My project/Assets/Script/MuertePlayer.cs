using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuertePlayer : MonoBehaviour
{
    public GameObject player;
    
    public void Update()
    {
        if (!player)
        {
            GameManager.getInstance().loser.SetActive(true);
            GameManager.getInstance().Perder();
        }
    }
}
