using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject collisionEffect;

    int bulletDamage;
    string targetTag;

    public void config(int damage, string target)
    {
        bulletDamage = damage;
        targetTag = target;
    }
    
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * 10;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == targetTag)
        {
            //deal damage
        }

        if(col.gameObject.tag != "player" && col.gameObject.tag != "wepon")
        {
            var colEff = Instantiate(collisionEffect, transform.position, Quaternion.identity);
            Destroy(colEff, 1);
            Destroy(gameObject);
        }

    }
}
