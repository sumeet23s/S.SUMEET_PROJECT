using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public bool shoot;

    /*

    public void Update()
    {
        if (Input.GetButtonDown("Fire1") && shoot == true)
        {
            Shoot();
        }

    }

     void Shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            

        ProgressBar obj = GameObject.Find("FillRefill").GetComponent<ProgressBar>();
        obj.slider.fillAmount = 0;
        shoot = false;
    }
    
    */



}
    

