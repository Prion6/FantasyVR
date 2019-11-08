using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject particle_impact;
    public ConstantForce force;

    public float lifeTime = 5;
    public float airResistance = 1;
    private float currentTime;

    private void Update()
    {
        force.relativeForce -= Vector3.forward * airResistance;

        Vector3 aux = force.relativeForce;

        aux.z = Mathf.Clamp(aux.z, 0, 1000000);

        force.relativeForce = aux;

        if (Time.time >= lifeTime * 60)
        {
            Destroy(this.gameObject);
        }
    }

    public void Impact()
    {
        Instantiate(particle_impact, transform.position, Quaternion.identity);
        transform.GetChild(0).SetParent(null);
        Destroy(this.gameObject);
    }
}
