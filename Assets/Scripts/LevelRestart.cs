using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRestart : MonoBehaviour
{
  public GameObject player;

  void Update()
  {
    if (player.transform.position.y <= -10 || Input.GetKeyDown(KeyCode.R)) // When player falls off the map or hits the reset key (R)
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload current scene
    }
  }
}