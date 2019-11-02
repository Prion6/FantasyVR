using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    private CharacterController player;

    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {   
        player.Move(new Vector3(horizontalMove,0,verticalMove)* playerSpeed);
    }
}
