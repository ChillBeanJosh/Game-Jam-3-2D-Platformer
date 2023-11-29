using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
 
 public int maxHealth;
 int currentHealth;
 static public int enemiesDefeated = 0;

 [SerializeField] AudioSource monsterSound;

 //Used for Enemies NOT destroyable surfaces.
 //Same as Destroy script but for enemies.

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
            
        }
    }

    void Die()
    {
        monsterSound.Play();
        Debug.Log("Enemy Died");
        Destroy(gameObject);
        enemiesDefeated++;

    }

   
}
