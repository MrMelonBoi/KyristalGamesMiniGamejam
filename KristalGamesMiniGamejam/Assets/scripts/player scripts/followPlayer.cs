using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Vector3 playerPos;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(GameObject.Find("player") != null)
        {
            playerPos = new Vector3(GameObject.Find("player").transform.position.x, GameObject.Find("player").transform.position.y, -10);
        }
    }

    void LateUpdate()
    {
        transform.position = playerPos;
    }
}
