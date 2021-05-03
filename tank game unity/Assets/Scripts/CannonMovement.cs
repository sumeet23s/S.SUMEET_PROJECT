using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{
    public float speed;
    bool collisiondetect;
    private float update;
   
   
    void Update()
    {

        update += Time.deltaTime;


        if (update >= 3.0f && update <=10.0f)
        {
          transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
        
        else if( update >= 10.0f && update <= 22.0f)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }
        else if(update >= 22.0f)
        {
            transform.Translate(0,-2 * Time.deltaTime * speed, 0);
        }
    }

}