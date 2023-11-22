using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
  public float speed;
  public float rayDist;
  private bool movingRight;
  public Transform groundDetect;

  void Update()
  {
    transform.Translate(Vector2.right * speed * Time.deltaTime); //Used to Move the Enemy Left and Right
    RaycastHit2D groundCheck = Physics2D.Raycast(groundDetect.position, Vector2.down, rayDist);

    if (groundCheck == false)
    {

        if (movingRight)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            movingRight = false;
        }
        else 
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            movingRight = true;
        }


    }
  }
}
