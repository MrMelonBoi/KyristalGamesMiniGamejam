using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DUJMAN : MonoBehaviour
{
    public float speed = 2f; //Folow Speed
    public bool hasTarget = false; //ilerlemek için bir hedefim var mý
    public GameObject target; //yaklaþmak istediðim hedef
    private Rigidbody2D rb;
    public GameObject Dujman;
    public Transform gameobject;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
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

    //  bir þey artýk benimle çarpýþmýyorsa bu kodu çalýþtýracaðým

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("PlayerObject"))
        {    // bu hedefimdeki target mi ?
            target = collision.gameObject;      // Hedefim olarak belirledim
            hasTarget = true;   //hedefim var
        }
    }

    //eðer fazla collider yaparsa benimle bu baþlar
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
        // Takip edebilmesi için güç ekle
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