using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyPLayer : MonoBehaviour
{
    public int life = 5;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HAAA");
        if (other.gameObject.tag == "Enemy_Bullet")
        {
            GetDamage();
        }

        if (other.gameObject.tag == "Skull")
        {
            Destroy(other.gameObject);
            GetDamage();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Heeee");
        if (other.gameObject.tag == "Enemy_Bullet")
        {
            GetDamage();
        }

        if (other.gameObject.tag == "Skull")
        {
            Destroy(other.gameObject);
            GetDamage();
        }
    }

    public void GetDamage()
    {
        source?.Play();
        life--;
        if(life <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
