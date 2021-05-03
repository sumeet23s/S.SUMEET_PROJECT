using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTankShooting : MonoBehaviour
{
    public Transform[] firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    Transform randomfirepoint;
    int index;
    float update;
    bool sus;
    bool next;


    public bool just;

    public void FixedUpdate()
    {
        if (just == true)
        {

            update += Time.deltaTime;
            sus = false;
            if (update >= 2.0f && sus == false && next == false)
            {

                Shoot();
            }


            if (firePoint[0] == null && firePoint[1] == null && firePoint[2] == null)

            {
                next = true;
                JetMovement obj = GameObject.Find("fighterjet").GetComponent<JetMovement>();
                obj.just = true;

                JetShooting obj1 = GameObject.Find("fighterjet").GetComponent<JetShooting>();
                obj1.just = true;

            }

        }
    }
        void Shoot()
        {
            index = Random.Range(0, firePoint.Length);

            if (firePoint[index] == null)
            {

                Shoot();

            }

            else
            {
                randomfirepoint = firePoint[index];
                GameObject bullet = Instantiate(bulletPrefab, randomfirepoint.position, randomfirepoint.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(randomfirepoint.up * bulletForce, ForceMode2D.Impulse);
                update = 0.0f;
                sus = true;

            }
        }

    
}

