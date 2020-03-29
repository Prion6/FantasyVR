using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl_Manager : MonoBehaviour
{
    SpawnPoint[] spawns;

    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        spawns = FindObjectsOfType<SpawnPoint>();

        foreach (var spawn in spawns)
        {
            spawn.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        timer.Init();

        foreach (var spawn in spawns)
        {
            spawn.gameObject.SetActive(true);
        }
    }
}
