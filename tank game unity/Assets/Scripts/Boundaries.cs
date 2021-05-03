using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
   
   public void FixedUpdate()
    {
       
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5.8f, 5.8f), transform.position.y, 0);
    }
}
