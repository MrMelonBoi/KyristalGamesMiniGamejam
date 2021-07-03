using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatPistol : MonoBehaviour
{
    public bool inHand, canShoot;

    public GameObject bullet;

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
        var bulletShot = Instantiate(bullet, transform.position, transform.rotation);
        bulletShot.GetComponent<bullet>().config(5, "enemy");
        Destroy(bulletShot, 5);
    }
}
