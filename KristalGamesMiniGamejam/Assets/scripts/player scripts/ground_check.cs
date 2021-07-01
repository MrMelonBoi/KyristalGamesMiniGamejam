using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_check : MonoBehaviour
{
    public bool groundedInput;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == 6)
        {
            groundedInput = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.layer == 6)
        {
            groundedInput = false;
        }
    }
}
