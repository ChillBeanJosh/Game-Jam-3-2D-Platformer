using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransfer : MonoBehaviour
{
  
  int levelTransport;
  void Start()
  {
    levelTransport = SceneManager.GetActiveScene().buildIndex;
    Debug.Log("build index " + levelTransport);
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {

    SceneManager.LoadScene(levelTransport + 1);

  }
}
