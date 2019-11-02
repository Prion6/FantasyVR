using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDetection : MonoBehaviour
{
    public enum Direction { Up, Down, Left, Right, Up_Left, Up_Right, Down_Left, Down_Right };
    public GameObject LeftHand;
    public GameObject RightHand;
    public GameObject player;
    public Direction dir;

    private void OnTriggerEnter(Collider other)
    {
        if (LeftHand.GetComponent<Collider>() == other )
        {
            Debug.Log("Mano Izquierda en " + dir);
        }
        if (RightHand.GetComponent<Collider>() == other)
        {
            Debug.Log("Mano Derecha en " + dir);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (LeftHand.GetComponent<Collider>() == other ||
            (player.GetComponent<Collider>() == other && Input.GetKey(KeyCode.A)))
        {
            Debug.Log("Mano Izquierda en " + dir);
        }
        if (RightHand.GetComponent<Collider>() == other ||
            (player.GetComponent<Collider>() == other && Input.GetKey(KeyCode.D)))
        {
            Debug.Log("Mano Derecha en " + dir);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Direccion" + dir);
        Debug.Log("sali del collider");
    
    }

}
