using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public Slider slider;
    public float FillSpeed = 0.5f;
    private float barvalue;
    public GameObject play;
    public Transform PlayPosition;
    bool sus;


    public void Awake()
    {

        slider = gameObject.GetComponent<Slider>();
    }


  public  void Start()
    {
        IncrementProgress();

    }

    public void FixedUpdate()
    {

        if (sus == false)
        {
            if (slider.value < 1)
            {
                IncrementProgress();
            }

            if (slider.value == 1)
            {
                //PlayButton obj = GameObject.Find("Button").GetComponent<PlayButton>();
                // obj.on = true;
                GameObject PlayButton = Instantiate(play, PlayPosition.position, PlayPosition.rotation);
                sus = true;

            }
        }  
    }           

   

    public void IncrementProgress()
    {
        slider.value += FillSpeed * Time.deltaTime;

    }
}

