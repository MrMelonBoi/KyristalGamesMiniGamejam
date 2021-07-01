using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketLauncher : MonoBehaviour
{
    public bool inHand, canShoot;

    public wepon wp;
    
    void Start()
    {
        wp = GetComponent<wepon>();
        canShoot = true;
    }

    
    void Update()
    {
        inHand = wp.equiped;

        if(Input.GetMouseButtonDown(0) && inHand && canShoot)
        {
            shoot();
        }
    }

    void shoot()
    {
        Debug.Log("rocket launcher shot!");
    }
}

