using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPoint : MonoBehaviour
{
  
  public Transform firePoint;
  public GameObject manaPrefab;

  public float fireRate;
  float nextFire;
  [SerializeField] AudioSource projectile;
  public Animator animator;
  
    // Update is called once per frame
    void Update()
    {
       
         if (Input.GetButtonDown("Fire1")) //"Fire1" is M1, can be changed in settings.
         {
            shoot();
         }
        
        
    }

    void shoot()
    {
        if (Time.time > nextFire)
        {
            animator.SetTrigger("Fire");
            
            projectile.Play();
            
            nextFire = Time.time + fireRate; //Controls the time it takes to shoot.
        
            Instantiate(manaPrefab, firePoint.position, firePoint.rotation); //Causes the Projectile to Spawn at the firePoint Transformation.
        }
    }
}
