﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonbulleteffect : MonoBehaviour
{

    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
       

            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.2f);
            Destroy(gameObject);
        }

    
}