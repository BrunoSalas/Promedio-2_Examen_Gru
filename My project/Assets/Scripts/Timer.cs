using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour , ISubject
{
    [SerializeField]
    private TMP_Text tiempoText;

    [SerializeField]
    private float initialTime = 60f;

    private float currentTime;

    public static Timer instance;
    public float timer;
    public IObserver spawn;
    private void Awake()
    {
        instance = this;
    }
    public static Timer GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        currentTime = initialTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        timer += Time.deltaTime;

        if (currentTime <= 0f)
        {
            SceneManager.LoadScene("Nivel 2");
            currentTime = 0f;

        }
        if (timer > 2)
        {
            Notify();
            timer = 0;
        }

        tiempoText.text = $"Tiempo: {currentTime.ToString("0")}";
    }

    public void Notify()
    {
        spawn.Execute(this);
    }

    public void Attach(IObserver observer)
    {
        spawn = observer;
    }

    public void Remove(IObserver observer)
    {

    }
}
