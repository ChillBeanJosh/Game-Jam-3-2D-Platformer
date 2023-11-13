using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
 public int health;

 public void TakeDamage (int damage) //Causes Object to take damage based on the Projectile Damage.
 {
    health -= damage;
 
    if (health <= 0)
    {
        Die();
    }
 }
 
 void Die()
 {
    Destroy(gameObject); //Removes the Object from the Scene. 
 }

 
}
