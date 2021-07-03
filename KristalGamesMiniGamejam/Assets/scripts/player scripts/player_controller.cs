using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float moveSpeed, jumpPower;

    public ground_check gc;
    public Rigidbody2D rb2d;

    public GameObject deathEffect;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //movement

        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0, 0);
        transform.position += moveInput;

        if(moveInput.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if(moveInput.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //jump

        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if(gc.groundedInput)
            {
                rb2d.AddForce(transform.up * 100 * jumpPower);
            }
            
        }
    }




    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
        
    }

}
