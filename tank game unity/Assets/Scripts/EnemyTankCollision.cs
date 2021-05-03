using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankCollision : MonoBehaviour
{
 
    int hit = 0;
    public bool check;
  
    void FixedUpdate()
    {
        enemyTankMovement obj = GameObject.Find("EnemyTank").GetComponent<enemyTankMovement>();
        check = obj.just;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {


        if ( check == true)
        {
            hit +=1;
            if (hit == 2)
            {
                Destroy(gameObject);

            }

            ScoreLine.scoreValue += 2;

        }

    }
}
