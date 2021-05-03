using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class JetShooting : MonoBehaviour
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

        }


        if (firePoint[0] == null && firePoint[1] == null)

        {
            SceneManager.LoadScene("Win");

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
                rb.AddForce(-randomfirepoint.up * bulletForce, ForceMode2D.Impulse);
                update = 0.0f;
                sus = true;
                
            }
        }
}

