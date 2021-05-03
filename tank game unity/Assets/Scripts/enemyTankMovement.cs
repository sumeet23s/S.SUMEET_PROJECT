using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTankMovement : MonoBehaviour
{
    
    public float speed;
   private float update;
    float add;
   public  bool just;


    void FixedUpdate() { 

        
        if (just == true)
        {

            add= 0.0f;
             add += Time.deltaTime;
            update += add;

            if (update >= 3.0f && update <= 10.0f)
            {
                transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            }

            else if (update >= 10.0f && update <= 22.0f)
            {
                transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            }
            else if (update >= 22.0f)
            {
                transform.Translate(0, -2 * Time.deltaTime * speed, 0);
            }
        }
    }
}




