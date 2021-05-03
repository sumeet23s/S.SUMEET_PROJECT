using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameOver GameOverScreen;

    GameObject gameprefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        

        GameOverScreen.Setup(ScoreLine.scoreValue);
    }
        
    }



