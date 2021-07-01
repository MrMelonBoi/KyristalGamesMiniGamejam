using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wepon_manager : MonoBehaviour
{
    public GameObject currentWepon;
    public Transform weponHolder;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void equipWepon(GameObject weponGot)
    {
        if(currentWepon != null)
        {
            Destroy(currentWepon);
        }
        currentWepon = weponGot;
        currentWepon.transform.parent = weponHolder;
        currentWepon.transform.localPosition = new Vector3(0.5f, 0, 0);
    }
}
