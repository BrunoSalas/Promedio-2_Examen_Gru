using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class SpawnNivel1 : MonoBehaviour , IObserver
{
    public float timer;
    public GameObject spawnPrefabEnemy;

    private void Awake()
    {
        Timer.GetInstance().Attach(this);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Execute(ISubject subject)
    {
        Instantiate(spawnPrefabEnemy, transform.parent.position + transform.localPosition, transform.parent.rotation);
    }


}
