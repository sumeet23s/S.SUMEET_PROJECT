using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnShooting : MonoBehaviour
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

        if (update >= 2.0f && sus == false && next == false)

        {
            Shoot();

        }


        if (firePoint[0] == null && firePoint[1] == null && firePoint[2] == null && firePoint[3] == null && firePoint[3] == null)

        {

            next = true;

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