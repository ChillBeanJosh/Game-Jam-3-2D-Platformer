using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayAgain : MonoBehaviour
{
  public void GameAgain()
  {
    Enemy.enemiesDefeated = 0;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
  }

}
