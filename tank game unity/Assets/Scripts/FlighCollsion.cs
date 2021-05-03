using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlighCollsion : MonoBehaviour
{
    int hit = 0;
    public bool check;

    void FixedUpdate()
    {
        JetMovement obj = GameObject.Find("fighterjet").GetComponent<JetMovement>();
        check = obj.just;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (check == true)
        {
            hit += 1;
            if (hit == 3)
            {
                Destroy(gameObject);
               
            }
            ScoreLine.scoreValue += 3;


        }

    }
}
