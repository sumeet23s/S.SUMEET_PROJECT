using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeLine : MonoBehaviour
{

    public Image[] lives;
    public int livesRemaining = 3;
    public bool hit;
   
    public GameOver GameOverScreen;


    public void LoseLife()
    {
        if (livesRemaining !=0)
        { 
        livesRemaining--;

        lives[livesRemaining].enabled = false;

        }

        if( livesRemaining ==0)
        {
            Debug.Log("gameover");

            GameOverScreen.Setup(ScoreLine.scoreValue);

        }

    }
   public void Update()
    {
        if(hit == true)
        {
            
            LoseLife();
            hit = false;


        }
    }
}
