using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Clear : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

        if(Enemy.enemiesDefeated == 1)
        {
            Destroy(gameObject);
        }
        
    }
}
