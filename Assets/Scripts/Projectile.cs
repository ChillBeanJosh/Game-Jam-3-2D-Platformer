using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed;
    public int damage;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    
    void Start() //Causes The Projectile To move Foward.
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name); //Used to Log What exactly the Projectile Hit.

        Destroy destroy = hitInfo.GetComponent<Destroy>(); //Anything with the Destroy Script attached Takes Damage according to the damage INT. 
        if (destroy != null)
        {
            destroy.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation); //Effect Whenever The Projectile Collides With Something.
        Destroy(gameObject); //Destroys the Projectile Whenever it hits on Object.
        
    }  
   
}
