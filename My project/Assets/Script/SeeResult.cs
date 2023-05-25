using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeeResult : MonoBehaviour
{
    public Contador a;
    public Text sum;

    private void Update()
    {

        int n1 = a.result;

        int resultTotal = n1;
        string resultado = resultTotal.ToString();


        sum.text = resultado;
    }
}
