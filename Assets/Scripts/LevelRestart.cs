using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRestart : MonoBehaviour
{
  [Tooltip("Reference to player object")]
  public GameObject player;
  public Animator transition;

  void Update()
  {
    if (player.transform.position.y <= -10 || Input.GetKeyDown(KeyCode.R)) // When player falls off the map or hits the reset key (R)
    {
      // StartCoroutine(ReloadLevel());
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      Debug.Log("Level reloaded");
    }
  }

  IEnumerator ReloadLevel()
  {
    transition.SetTrigger("Die");

    yield return new WaitForSeconds(5);

    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}