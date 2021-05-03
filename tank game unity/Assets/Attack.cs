using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject attack;
    float tn;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {

        tn += Time.deltaTime;

        if ( tn> 1.0f && tn< 2.0f)
        {
            attack.SetActive(true);
            
        }

        if(tn > 3.0f)
        {
            attack.SetActive(false);
        }
    }
}
