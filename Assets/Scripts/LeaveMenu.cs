using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveMenu : MonoBehaviour
{
  public void LeaveGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }
}