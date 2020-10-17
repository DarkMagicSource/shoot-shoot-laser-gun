using UnityEngine;

public class PauseUI : MonoBehaviour
{
  public static bool GameIsPause = false;

  public GameObject pauseMenuUI;
  public GameObject pauseMenuOverlay;

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      if (GameIsPause)
      {
        Resume();
      }
      else
      {
        Pause();
      }
    }
  }

  public void Resume()
  {
    pauseMenuUI.SetActive(false);
    pauseMenuOverlay.SetActive(false);
    Time.timeScale = 1f;
    GameIsPause = false;
  }

  void Pause()
  {
    pauseMenuUI.SetActive(true);
    pauseMenuOverlay.SetActive(true);
    Time.timeScale = 0f;
    GameIsPause = true;
  }
}