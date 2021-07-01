using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float moveSpeed;

    public ground_check gc;
    public Rigidbody2D rb2d;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //movement

        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0, 0);
        transform.position += moveInput;

        //jump



        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if(gc.groundedInput)
            {
                rb2d.AddForce(transform.up * 300);
            }
            
        }
    }
}
