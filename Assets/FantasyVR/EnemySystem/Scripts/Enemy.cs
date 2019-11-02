using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void Kill()
    {
        GetComponent<Animator>().enabled = false;
    }
}
