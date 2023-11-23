using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Clear : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Enemy.enemiesDefeated == 4)
        {
            Destroy(gameObject);
        }
        
    }
}
