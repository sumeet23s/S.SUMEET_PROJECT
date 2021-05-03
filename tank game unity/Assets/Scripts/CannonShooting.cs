using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
public class CannonShooting : MonoBehaviour 
{
    public Transform [] firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    Transform randomfirepoint;
    int index;
    float update;
    bool sus;
    public  bool check;

  public  void FixedUpdate()
    {

       if (firePoint[index] != null)
      {

            update += Time.deltaTime;
            sus = false;
            if (update >= 2.0f && sus == false)
            {
                Shoot();
            }
            
       }
     
      if(firePoint[0] == null  && firePoint[1] == null && firePoint[2] == null && firePoint[3] == null)
     
        {
            enemyTankMovement obj = GameObject.Find("EnemyTank").GetComponent<enemyTankMovement>();
            obj.just = true;
            
            enemyTankShooting obj1 = GameObject.Find("EnemyTank").GetComponent<enemyTankShooting>();
            obj1.just = true;

        }
        
    }
    public  void Shoot()
    {
        index = Random.Range(0, firePoint.Length);

        if( firePoint [index] == null){

            Shoot();

        }

        else {
            randomfirepoint = firePoint[index];
            GameObject bullet = Instantiate(bulletPrefab, randomfirepoint.position, randomfirepoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(-randomfirepoint.up * bulletForce, ForceMode2D.Impulse);
            update = 0.0f;
            sus = true;
        }
    }
}
*/

public class CannonShooting : MonoBehaviour
{
    public Transform[] firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    Transform randomfirepoint;
    int index;
    float update;
    bool sus;
    bool next;

    public void FixedUpdate()
    {


            update += Time.deltaTime;
            sus = false;

            if (update >= 2.0f && sus == false && next==false)

            {
                Shoot();
                
            }
        
       
        if (firePoint[0] == null && firePoint[1] == null && firePoint[2] == null && firePoint[3] == null)

        {

            next = true;
            enemyTankMovement obj = GameObject.Find("EnemyTank").GetComponent<enemyTankMovement>();
            obj.just = true;

            enemyTankShooting obj1 = GameObject.Find("EnemyTank").GetComponent<enemyTankShooting>();
            obj1.just = true;
           
          

        }

    }
    public void Shoot()
    {
        index = Random.Range(0, firePoint.Length);

        if (firePoint[index] == null)
        {

            Shoot();

        }

        else
        {

            GameObject bullet = Instantiate(bulletPrefab, firePoint[index].position, firePoint[index].rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(-firePoint[index].up * bulletForce, ForceMode2D.Impulse);
            update = 0.0f;
            sus = true;
            

        }
    }
}