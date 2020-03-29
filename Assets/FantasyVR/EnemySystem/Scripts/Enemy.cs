using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool alive = true;
    public int pointReward;

    public Bullet bullet;
    public Transform pivot;
    private float timer = 0;

    private void Start()
    {

    }

    private void Update()
    {
        if(timer >=10)
        {
            timer = 0;
            Shoot();
        }
        timer += Time.deltaTime;
    }

    [ContextMenu("Kill")]
    public void Kill()
    {
        if (alive)
        {
            GetComponent<Animator>().enabled = false;
            alive = false;

            transform.SetLayer(LayerMask.NameToLayer("Body"));
            //PointsHUD.AddPoints(pointReward);
        }
    }

    public void Vanish()
    {
        Destroy(gameObject);
    }

    public void Shoot()
    {
        Instantiate(bullet,pivot);   
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            MyPLayer.score += 100;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            MyPLayer.score += 100;
        }
    }

}



public static class TransformExtensions
{
    public static void SetLayer(this Transform trans, int layer)
    {
        trans.gameObject.layer = layer;
        foreach (Transform child in trans)
            child.SetLayer(layer);
    }
}
