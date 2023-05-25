using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public int plusAmount = 1;

    public int result = 0;



    public void OnButtononClick()
    {
        result += plusAmount;
    }
}
