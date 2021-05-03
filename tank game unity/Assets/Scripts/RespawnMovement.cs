using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnMovement : MonoBehaviour
{
    public float speed;
    
    private float update;


    void Update()
    {

        update += Time.deltaTime;


        if (update >= 3.0f && update <= 10.0f)
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
        }

        else if (update >= 14.0f && update <= 22.0f)
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
        else if (update >= 22.0f && update <= 30.0f)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }
        else if( update >= 30.0f)
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
        }
    }

}
