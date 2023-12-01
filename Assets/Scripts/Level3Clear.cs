using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Clear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void Update()
    {
        if(Enemy.enemiesDefeated == 10)
        {
            Destroy(gameObject);
        }
        
    }
}
