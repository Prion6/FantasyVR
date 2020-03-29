using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    public Timer timer;
    public int pointReward;
    // Start is called before the first frame update
    void Start()
    {
        //timer.OnFinish += Vanish;
        //timer.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Bullet"))
        {
            Die();
        }
    }

    public void Die()
    {
        //PointsHUD.AddPoints(pointReward);
        Destroy(gameObject);
    }

    public void Vanish()
    {
        Destroy(gameObject);
    }
}
