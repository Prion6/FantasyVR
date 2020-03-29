using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class boxButton : MonoBehaviour
{
    public UnityEvent StartGame;

    public void OnCollisionEnter(Collision other)
    {
        var bullet = other.gameObject.GetComponent<Bullet>();
        if (bullet != null)
        {
            StartGame?.Invoke();
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var bullet = other.gameObject.GetComponent<Bullet>();
        if (bullet != null)
        {
            StartGame?.Invoke();
            Destroy(this.gameObject);
        }
    }
}
