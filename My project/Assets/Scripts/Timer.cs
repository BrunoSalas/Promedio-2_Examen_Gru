using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TMP_Text tiempoText;

    [SerializeField]
    private float initialTime = 60f;

    private float currentTime;

    private void Start()
    {
        currentTime = initialTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            SceneManager.LoadScene("Nivel 2");
            currentTime = 0f;

        }

        tiempoText.text = $"Tiempo: {currentTime.ToString("0")}";
    }

}
