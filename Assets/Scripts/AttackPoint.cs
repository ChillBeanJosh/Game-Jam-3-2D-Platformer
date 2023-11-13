using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPoint : MonoBehaviour
{
  
  public Transform firePoint;
  public GameObject manaPrefab;

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
        Instantiate(manaPrefab, firePoint.position, firePoint.rotation); //Causes the Projectile to Spawn at the firePoint Transformation.

    }
}
