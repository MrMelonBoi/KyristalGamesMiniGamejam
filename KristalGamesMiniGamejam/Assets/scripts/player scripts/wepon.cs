using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wepon : MonoBehaviour
{
    public bool equiped;
    
    void Start()
    {
        equiped = false;
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "player")
        {
            col.gameObject.GetComponent<wepon_manager>().equipWepon(gameObject);
            equiped = true;
        }
    }
}
