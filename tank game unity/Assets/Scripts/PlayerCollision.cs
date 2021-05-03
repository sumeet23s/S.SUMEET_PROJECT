using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    int noofhits;
 
    void Update()
    {
       
    }

   public void OnCollisionEnter2D(Collision2D collision)
    {
        LifeLine obj = GameObject.Find("LifeLine").GetComponent<LifeLine>();
        obj.hit = true;
        noofhits++;
        if(noofhits == 3)
        {
            Destroy(gameObject);
        }
   

    }
}
