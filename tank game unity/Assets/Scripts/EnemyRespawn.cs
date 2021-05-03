using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public Transform SpawnTransform;
    public GameObject[] SpawnPrefab;
    public bool Cannon;

     int time = 0;
    public void Update()
    {
        if (Cannon == true && time < 1)
        {

            Instantiate(SpawnPrefab[0], SpawnTransform.position, SpawnTransform.rotation);
            time ++;
            Cannon = false;

        }

        if ( SpawnPrefab[0] == null && time < 1)
        {
            Instantiate(SpawnPrefab[1], SpawnTransform.position, SpawnTransform.rotation);
            time++;
        }

        if( SpawnPrefab[1] == null && time < 1)
        {
            Instantiate(SpawnPrefab[2], SpawnTransform.position, SpawnTransform.rotation);
            time++;
        }
        if( SpawnPrefab [2] == null && time < 1)
        {
            Instantiate(SpawnPrefab[0], SpawnTransform.position, SpawnTransform.rotation);
            time++;

            if( SpawnPrefab[2] == null)
            {
                Cannon = true;
            }
        }
        
        

    }
}
