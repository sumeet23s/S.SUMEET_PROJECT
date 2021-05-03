using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgressBar : MonoBehaviour
{
    public Image slider;
    public float FillSpeed = 0.5f;


    public GameObject changecolour;
   

    
    private void Awake()
    {
        slider = gameObject.GetComponent<Image>();
        

    }


  public  void Start()
    {
        IncrementProgress();
      
    }

    public void FixedUpdate()
    {
        GameObject obj1 = GameObject.FindGameObjectWithTag("Player");

        if (obj1 != null)
        {

            shootButton obj = GameObject.Find("ShootButton").GetComponent<shootButton>();
            if (obj.shoot == false)
            {



                if (slider.fillAmount < 1)
                {
                    IncrementProgress();
                    changecolour.SetActive(false);
                }
                if (slider.fillAmount == 1)
                {
                    obj.shoot = true;

                    changecolour.SetActive(true);
                }




            }

        }

    }

    public void IncrementProgress()
    {
        slider.fillAmount += FillSpeed * Time.deltaTime;
        
    }
}
