using UnityEngine;

public class PauseMenu : MonoBehaviour
{
  public PauseUI pauseMenu;

  public void ResumeGame()
  {
    pauseMenu.Resume();
  }
}
