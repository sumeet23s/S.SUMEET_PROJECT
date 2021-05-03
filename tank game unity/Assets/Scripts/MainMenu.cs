using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject pauseScreen;
    bool gamePaused;

   public void Start()
    {
        gamePaused = false;
    }


    public void Update()
    {
        if (gamePaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }


public void settings()
    {
        SceneManager.LoadScene("Settings");
    }



    public void restartscene()
    {
        SceneManager.LoadScene("Tank shooting");
        ScoreLine.scoreValue = 0;
    }




    public void ResumeGame()
    {
        gamePaused = false;
        pauseScreen.SetActive(false);
        
    }

    public void pauseGame()
    {
        gamePaused = true;
        pauseScreen.SetActive(true);

    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        ScoreLine.scoreValue = 0;
    }
}


