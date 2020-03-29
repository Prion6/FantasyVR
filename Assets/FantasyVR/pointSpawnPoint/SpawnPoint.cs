using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject toSpawn;

    private GameObject spawned;

    public float deltaTimer = 10;
    private float timer = 0;


    private void Awake()
    {
        var refernece = transform.GetChild(0);
        Destroy(refernece.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if(spawned == null)
        {
            if(timer >= deltaTimer)
            {
                timer = 0;
                spawned = Instantiate(toSpawn, transform.position, transform.rotation,transform);
            }
            timer += Time.deltaTime;
        }
    }
}
