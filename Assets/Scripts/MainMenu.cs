using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void LoadGame()
  {
    Debug.Log("WIP");
  }

  public void OptionsMenu()
  {
    Debug.Log("WIP");
  }

  public void QuitGame()
  {
    Application.Quit();
    UnityEditor.EditorApplication.isPlaying = false;
    Debug.Log("Quitting...");
  }
}