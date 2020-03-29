using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    private Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<MyPLayer>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        this.transform.Translate(Vector3.forward * speed* Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            MyPLayer.score += 300;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            MyPLayer.score += 300;
            Destroy(gameObject);
        }
    }
}
