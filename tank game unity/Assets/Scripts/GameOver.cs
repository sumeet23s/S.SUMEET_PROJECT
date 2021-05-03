using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text pointsText;


    public void Setup(int score)
    {

        gameObject.SetActive(true);
        pointsText.text =  score.ToString();
 
    }

    public void RestartButton()
    {
        ScoreLine.scoreValue = 0;
        SceneManager.LoadScene("Tank Shooting");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
