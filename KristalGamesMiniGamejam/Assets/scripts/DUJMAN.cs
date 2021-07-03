using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DUJMAN : MonoBehaviour
{
    public float speed = 2f; //Folow Speed
    public bool hasTarget = false; //ilerlemek i�in bir hedefim var m�
    public GameObject target; //yakla�mak istedi�im hedef
    private Rigidbody2D rb;
    public GameObject Dujman;
    public Transform gameobject;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(target == null)
        {
            return;
        }

        if (hasTarget)
        {
            //get distance between me and my target
            float distance = Vector3.Distance(transform.position, target.transform.position);
            // am I further than 2 units away
            if (distance > 2)
            {
                // I am over 2 units away
                follow(target.transform); // do a follow
            }
        }
    }

    //  bir �ey art�k benimle �arp��m�yorsa bu kodu �al��t�raca��m

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("PlayerObject"))
        {    // bu hedefimdeki target mi ?
            target = collision.gameObject;      // Hedefim olarak belirledim
            hasTarget = true;   //hedefim var
        }
    }

    //e�er fazla collider yaparsa benimle bu ba�lar
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name.Equals("PlayerObject"))
        {
            target = null;
            hasTarget = false;
        }
    }

    private void follow(Transform target)
    {
        // Takip edebilmesi i�in g�� ekle
        rb.AddForce((target.transform.position - transform.position).normalized * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals ("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}