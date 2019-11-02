using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BodyPart : MonoBehaviour
{
    public LayerMask collidableObjects;

    public UnityEvent onCollisionEnter;

    private void OnCollisionEnter(Collision collision)
    {
        if ((collidableObjects.value & (1 << collision.collider.gameObject.layer)) > 0)
        {
            print(collision.collider.name);
            onCollisionEnter.Invoke();
        }
    }
}
