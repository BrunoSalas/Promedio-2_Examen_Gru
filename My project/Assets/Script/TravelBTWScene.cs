using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TravelBTWScene : MonoBehaviour
{
    public Button button;
    public string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
       
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }

}
