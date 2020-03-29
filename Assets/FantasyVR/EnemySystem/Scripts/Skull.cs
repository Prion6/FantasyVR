using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Skull : MonoBehaviour
{
    public Transform target;
    private Rigidbody rb;
    public float movForce;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<OVRPlayerController>().transform;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        rb.AddForce(movForce*Vector3.forward);
    }
}
