﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCollision : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D collision)
    {

            if( collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            ScoreLine.scoreValue += 1;
        }
        
        
    }
}