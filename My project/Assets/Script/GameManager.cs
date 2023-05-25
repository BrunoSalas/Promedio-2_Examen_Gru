using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int victoria;
    public int perder;
    public int botonCredito;
    public GameObject loser;
    public GameObject victory;

    public static GameManager Instance;

    public void hola()
    {
        Time.timeScale = 1;
        loser.SetActive(false);
        victory.SetActive(false);
    }
    public static GameManager getInstance()
    {
        return Instance;
    }

    public void Victoria()
    {
        Time.timeScale = 0;
        victoria++;
    }

    public void Perder()
    {

        perder++;
    }

    public void BotonCredito()
    {
        botonCredito++;
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
