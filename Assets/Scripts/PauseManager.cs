using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    private bool isGamePaused = false;

    public void TogglePause()
    {
        

        if (isGamePaused)
        {
            ResumeGame();
            
        }
        else
        {
            PauseGame();
            
        }

        isGamePaused = !isGamePaused;
    }

    private void PauseGame()
    {
        Time.timeScale = 0f;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


}
