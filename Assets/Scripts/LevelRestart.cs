using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRestart : MonoBehaviour
{
  public GameObject player;

  void Update()
  {
    if (player.transform.position.y <= -10 || Input.GetKeyDown(KeyCode.R))
    {
      // Scene scene = SceneManager.GetActiveScene();
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  }
}