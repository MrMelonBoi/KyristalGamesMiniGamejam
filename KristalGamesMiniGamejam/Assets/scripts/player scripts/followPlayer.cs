using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        if(GameObject.Find("player") != null)
        {
            transform.position = new Vector3(GameObject.Find("player").transform.position.x, GameObject.Find("player").transform.position.y, -10);
        }
        
    }
}
