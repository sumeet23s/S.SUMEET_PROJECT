using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Restart : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    // Start is called before the first frame updatepub
    public void restartscene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void Game()
    {
        SceneManager.LoadScene("Tank shooting");
    }

    public void ResumeGame()
    {

        Time.timeScale = 1.0f;
        SceneManager.UnloadSceneAsync("Tank shooting");

    }
}
