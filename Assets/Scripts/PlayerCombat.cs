using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage;

    public float meleeRate = 2f;
    float nextMeleeAttack = 0f;

    void Update()
    {
        if(Time.time >= nextMeleeAttack)
        {
            if (Input.GetKeyDown(KeyCode.Q)) //Attack Key for Melee Attack.
          {
            Attack();
            nextMeleeAttack = Time.time + 1f / meleeRate; //Melee Cooldown.
          }   
        }
    }

    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); //Creates an array to only allow Objects tagged "Enemy" to be hit.

        foreach(Collider2D enemy in hitEnemies)
        {
           enemy.GetComponent<Enemy>().TakeDamage(attackDamage); //calculates the damage using Enemy Script.
           Debug.Log("We hit " + enemy.name);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange); //Creates the Circular hitbox for the melee attack.
    }
}
