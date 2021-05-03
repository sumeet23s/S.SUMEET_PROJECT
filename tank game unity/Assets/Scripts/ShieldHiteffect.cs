using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldHiteffect : MonoBehaviour
{
  
    public GameObject hitEffect;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 2f);    
    }
}
